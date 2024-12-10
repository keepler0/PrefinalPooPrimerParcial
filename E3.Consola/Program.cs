using ConsoleHelper;
using E3.Entidades;

namespace E3.Consola
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var nr = new NumReal();//por default grado=5
			var nc = new NumComplejo();//por default grado=5
            Console.WriteLine(nr.GetInformacion());
            Console.WriteLine(nc.GetNumeroComplejo());

			var nr1 = new NumReal(10f);
			var nc1= new NumComplejo(10f);
			nc1.ValorImaginario = 15f;
			var nc2 = new NumComplejo(20f);
			nc2.ValorImaginario = 30f;

			//Suma de NumerosComplejos
			var nc3 = nc1 + nc2;
            Console.WriteLine(nc3.GetNumeroComplejo());
            Console.WriteLine(nc3.GetInformacion());
			//suma de Numcomplejo y NumReal
			var nc4 = nr1 + nc1;
			Console.WriteLine(nc4.GetNumeroComplejo());
			Console.WriteLine(nc4.GetInformacion());

            
			
			try
			{
				Console.WriteLine("Suma numReal+NumComplejo...");
				var valor = ConsoleExtensions.GetFloat("Ingrese el valor:");
				var nr2 = new NumReal(valor);
				valor = ConsoleExtensions.GetFloat("Ingrese el valor:");
				var valorImaginario = ConsoleExtensions.GetFloat("Ingrese el valor imaginario:");
				var nc5 = new NumComplejo(valor);
				nc5.ValorImaginario= valorImaginario;
				var resultado = nr2 + nc5;
				Console.WriteLine(resultado.GetInformacion());
                Console.WriteLine(resultado.GetNumeroComplejo());
				Console.ReadKey();
				Console.Clear();
				Console.WriteLine("Suma numComplejo+NumComplejo...");
				valor = ConsoleExtensions.GetFloat("Ingrese el valor:");
				valorImaginario = ConsoleExtensions.GetFloat("Ingrese el valor imaginario:");
				var numComplejo = new NumComplejo(valor);
				numComplejo.ValorImaginario = valorImaginario;

				valor = ConsoleExtensions.GetFloat("Ingrese el valor:");
				valorImaginario = ConsoleExtensions.GetFloat("Ingrese el valor imaginario:");
				var numComplejo1 = new NumComplejo(valor);
				numComplejo1.ValorImaginario = valorImaginario;
				resultado = nr2 + nc5;
				Console.WriteLine(resultado.GetInformacion());
				Console.WriteLine(resultado.GetNumeroComplejo());
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}

			Console.ReadKey();
		}
	}
}
