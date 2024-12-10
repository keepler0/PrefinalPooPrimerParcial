using E4.Entidades;
using System;
using System.Text;
using System.Timers;

namespace E4.Datos
{
	public class Repositorio
	{
		private int _cantidad;
		public int Cantidad => _cantidad;
		private NumHarshad?[] array;
        public Repositorio(int cantidad)
        {
            _cantidad=cantidad;
			array = new NumHarshad[cantidad];
        }
        public Repositorio() : this(5) { }
		private bool estaVacio()
		{
			if (array is null) return true;
			int cantidad = 0;
			foreach (var item in array)
			{
				if (item is not null)
				{
					cantidad += 1;
				}
			}
			return cantidad == 0;
		}
		private bool estaCompleto()
		{
			if (array is null) return false;
			int cantidad = 0;
			foreach (var item in array)
			{
				if (item is not null)
				{
					cantidad += 1;
				}
			}
			return cantidad == _cantidad;
		}
		private bool Existe(NumHarshad num)
		{
			if (array is null) return false;
			foreach (var item in array)
			{
				if (item is not null)
				{
					return item == num;
				}
			}
			return false;
		}
		public (bool,string) Agregar(NumHarshad num)
		{
			if (num is null) return (false, "El numero harshad tiene valor nulo");
			if (estaCompleto()) return (false, "Array completo");
			if (Existe(num)) return (false, "El numero ya existe en el array");
			for (int i = 0; i < _cantidad; i++)
			{
				if (array[i] is null)
				{
					array[i] = num;
					break;
				}
			}
			return (true, "Numero agregado");
		}
		public (bool, string) Borrar(NumHarshad num)
		{
			if (num is null) return (false, "El numero harshad tiene valor nulo");
			if (estaVacio()) return (false, "Array vacio");
			if (!Existe(num)) return (false, "El numero no existe en el array");
			for (int i = 0; i < _cantidad; i++)
			{
				if (array[i] is not null && array[i]==num)
				{
					array[i] = null;
					break;
				}
			}
			return (true, "Numero borrado");
		}
		public NumHarshad? GetNumHarshad(int index)
		{
			if (array is null) return null;
			if (index < 0 && index > _cantidad) throw new ArgumentOutOfRangeException("Indice fuera de rango");
			return array[index];
		}
		public string GetLista()
		{
			var sb = new StringBuilder();
			if (estaVacio()) return "Aun no hay elementos almacenados";
			for (int i = 0; i < _cantidad; i++)
			{
				if (array[i] is null)
				{
					sb.AppendLine($"{i} - Elemento nulo");
				}
				else
				{
					sb.AppendLine($"{i} - {array[i]!.valor.ToString()}");
				}
			}
			return sb.ToString();
		}
		public (bool,int) GetIndexDelNum(NumHarshad num)
		{
			if (estaVacio()) return (false, -1);
			if (!Existe(num)) return (false, -1);
			for (int i = 0; i < _cantidad; i++)
			{
				if (array[i] is not null && array[i] == num)
				{
					return (true, i);
				}
			}
			return (false, -1);
		}
		public static implicit operator int(Repositorio r)
		{
			if (r is null) return 0;
			if (r.array is null) return 0;
			if (r.estaVacio()) return 0;
			var suma = 0;
			for (int i = 0; i < r.Cantidad; i++)
			{
				if (r.array[i] is not null)
				{
					suma += r.array[i]!.valor;
				}
			}
			return suma;
		}
	}
}
