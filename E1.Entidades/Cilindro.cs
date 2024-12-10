using System.Text;

namespace E1.Entidades
{
	public class Cilindro
	{
		private double _radio;
		private double _altura;

		public Cilindro(double radio, double altura)
		{
			_radio = radio>0?radio:
				throw new ArgumentException("El valor del radio debe ser mayor a cero");
			_altura = altura>0?altura: 
				throw new ArgumentException("El valor de la altura debe ser mayor a cero"); ;
		}

		private double _areaBase => Math.PI * Math.Pow(_radio, 2);
		public double Altura
		{
			get { return _altura; }
			set { _altura = value; }
		}
		public double Radio
		{
			get { return _radio; }
			private set { _radio = value; }
		}
		public double GetAreaTotal() => 2 * Math.PI * (_radio + _altura);
		public double GetVolumen() => Math.PI * Math.Pow(_radio, 2) * _altura;
		public string GetDatos()
		{
			var sb = new StringBuilder();
			sb.AppendLine("Datos del cilintro.....");
			sb.AppendLine($"Radio: {Radio}");
			sb.AppendLine($"Altura: {Altura}");
			sb.AppendLine($"Area total: {GetAreaTotal().ToString("N2")}");
			sb.AppendLine($"Volumen: {GetVolumen().ToString("N2")}");
			return sb.ToString();
		}
	}
}
