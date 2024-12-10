namespace ConsoleHelper
{
	public static class ConsoleExtensions
	{
		public static double GetValue(string message)
		{
			double value = 0;
			Console.Write(message);
			do
			{
				if (double.TryParse(Console.ReadLine(), out value))
				{
					break;
				}
				Console.WriteLine("Debe ingresar un valor numerico");
			} while (true);
			return value;
		}
		public static float GetFloat(string message)
		{
			float value = 0f;
			Console.Write(message);
			do
			{
				if (float.TryParse(Console.ReadLine(), out value))
				{
					break;
				}
				Console.WriteLine("Debe ingresar un valor numerico");
			} while (true);
			return value;
		}
		public static int GetInt(string message)
		{
			int value = 0;
			Console.Write(message);
			do
			{
				if (int.TryParse(Console.ReadLine(), out value))
				{
					break;
				}
				Console.WriteLine("Debe ingresar un valor numerico");
			} while (true);
			return value;
		}
	}
}
