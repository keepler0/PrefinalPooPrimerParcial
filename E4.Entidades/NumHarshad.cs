namespace E4.Entidades
{
	public class NumHarshad
	{
		private int _valor;

		public NumHarshad(int valor)
		{
			_valor = valor;
		}

		public int valor => _valor;
		public bool EsHarshad()
		{
			int valor = _valor;
			int suma = 0;
			while (valor>0)
			{
				suma += valor % 10;
				valor /= 10;
			}
			return suma!=0 && valor%suma==0;
		}
		public override bool Equals(object? obj)
		{
			if (obj is null) return false;
			if (obj.GetType() != this.GetType()) return false;
			return this.valor == this.valor;
		}
		public override int GetHashCode()
		{
			unchecked
			{
				var hash = 17;
				hash += valor.GetHashCode() * 23;
				return hash;
			}
		}
	}
}
