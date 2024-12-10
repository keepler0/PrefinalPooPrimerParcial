using ConsoleHelper;
using E1.Entidades;

namespace E1.Consola
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var c = new Cilindro(10, 5);
            Console.WriteLine(c.GetDatos());
            Console.WriteLine("Creando nuevo cilindro....");
			var radio = ConsoleExtensions.GetValue("Ingrese el radio: ");
			var altura = ConsoleExtensions.GetValue("Ingrese la altura: ");
			try
			{
				var c1 = new Cilindro(radio, altura);
				Console.WriteLine(c1.GetDatos());
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
			Console.ReadKey();
		}
	}
}
