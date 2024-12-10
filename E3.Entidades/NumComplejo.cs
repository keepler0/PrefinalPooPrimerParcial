using System.Numerics;

namespace E3.Entidades
{
	public class NumComplejo
	{
		private float _valor;
		private float _valorImaginario;

		public float ValorImaginario
		{
			get { return _valorImaginario; }
			set { _valorImaginario = value > 0 ? value : throw new Exception("Valor incorrecto"); }
		}
		public float Valor
		{
			get { return _valor; }
			set { _valor = value > 0 ? value : throw new Exception("Valor incorrecto"); }
		}
        public NumComplejo():this(5)
        {
        }
        public NumComplejo(float grados)
        {
			Valor = grados; 
        }
        public string GetInformacion() => 
			$"valor: {Valor}\n valor imaginario: {ValorImaginario}\n Modulo={CalcularModulo().ToString("N2")}";
		public string GetNumeroComplejo() => $"{Valor}+{ValorImaginario}i";

		public static NumComplejo operator +(NumComplejo a, NumComplejo b)
		{
			var valor=a.Valor+b.Valor;
			var valorImaginario=a.ValorImaginario+b.ValorImaginario;
			var num= new NumComplejo(valor);
			num.ValorImaginario=valorImaginario;
			return num;
		}
		public static NumComplejo operator +(NumComplejo nc,NumReal nr)
		{
			var valor = nc.Valor + nr.Valor;
			var num = new NumComplejo(valor);
			return num;
		}
		public static implicit operator NumComplejo(NumReal nr)
		{
			return new NumComplejo(nr.Valor);
		}
		public float CalcularModulo() => (float)Math.Sqrt(Math.Pow(Valor, 2) + Math.Pow(ValorImaginario, 2));
	}
}
