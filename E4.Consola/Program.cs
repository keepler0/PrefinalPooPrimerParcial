using ConsoleHelper;
using E4.Datos;
using E4.Entidades;

namespace E4.Consola
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var repositorio = new Repositorio();
			do
			{
				Console.WriteLine("[1]Agregar");
				Console.WriteLine("[2]Borrar");
				Console.WriteLine("[3]Ver lista");
				Console.WriteLine("[4]Buscar por indice");
				Console.WriteLine("[5]Obtener indice del numero");
				Console.WriteLine("[6]Obtener suma total de la lista");
				int select = ConsoleExtensions.GetInt("Seleccione alguna opcion: ");
				switch (select)
				{
					case 1:
						Agregar(repositorio);
						break;
					case 2:
						Borrar(repositorio);
						break;
					case 3:
						MostrarLista(repositorio);
						break;
					case 4:
						BuscarPorIndex(repositorio);
						break;
					case 5:
						break;
					case 6:
						break;
					default:
						break;
				} 
			} while (true);
		}

		private static void BuscarPorIndex(Repositorio repositorio)
		{
			int index = ConsoleExtensions.GetInt("Indique el indice: ");
			var item = repositorio.GetNumHarshad(index);
			if (item is not null)
			{
				Console.WriteLine($"El numero en el indice: {index} es {item.valor}");
			}
			else
			{
                Console.WriteLine("No se encontro el elemento");
			}

		}

		private static void MostrarLista(Repositorio repositorio)
		{
			if (repositorio is not null)
			{
                Console.WriteLine(repositorio.GetLista());

			}
		}

		private static void Borrar(Repositorio repositorio)
		{
            Console.WriteLine("Borrar un elemento de la lista");
            Console.WriteLine($"{repositorio.GetLista()}");
			var index = ConsoleExtensions.GetInt("Indique el indice del elemento a eliminar: ");
			var item = repositorio.GetNumHarshad(index);
			if (item is not null)repositorio.Borrar(item);
            Console.WriteLine("Borrado");
		}

		private static void Agregar(Repositorio repositorio)
		{
            Console.WriteLine("Agregando numero harshad");
			do
			{
				var valor = ConsoleExtensions.GetInt("Ingrese el valor: ");
				var num = new NumHarshad(valor);
				if (num.EsHarshad())
				{
					repositorio.Agregar(num);
                    
					break;
				}
				else
				{
                    Console.WriteLine("El valor no corresponde a un numero harshad");
				}
			} while (true);
            Console.WriteLine("Numero agregado");
		}
	}
}
