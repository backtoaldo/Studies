using System;
using System.Globalization;

namespace Course {
	class Program {
		static void Main(string [] args) {

			Console.Write("Digite tres numeros:");
			double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			while (x >= 0.0) {
			double raiz = Math.sqrt(x)
			Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
			Console.Write("Digite outro numero: ");
			x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			
			}
		}
	}
}
