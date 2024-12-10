namespace E3.Entidades
{
	public class NumReal
	{
		private float _valor;

		public float Valor
		{
			get { return _valor; }
			set { _valor = value>0?value:throw new Exception("Valor incorrecto"); }
		}
		public NumReal() : this(5)
		{
		}
		public NumReal(float grados)
		{
			Valor = grados;
		}
		public string GetInformacion() => $"valor: {Valor}";
	}
}
