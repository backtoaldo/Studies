//representando o triangulo sem usar orientacao a objetos
using System;
using System.Globalization;

namespace Course {
	class Program {
		static void Main(string[] args) {

			double xA, xB, xC, Ya, Yb, Yc

			Console.WriteLine("Entre com as medidas do triangulo X:");
			xA = double.Parse(Console.Readline(), CultureInfo.InvariantCulture);
			xB = double.Parse(Console.Readline(), CultureInfo.InvariantCulture);
			xC = double.Parse(Console.Readline(), CultureInfo.InvariantCulture);

			Console.WriteLine("Entre com as medidas do triangulo Y:");
			yA = double.Parse(Console.Readline(), CultureInfo.InvariantCulture);
			yB = double.Parse(Console.Readline(), CultureInfo.InvariantCulture);
			yC = double.Parse(Console.Readline(), CultureInfo.InvariantCulture);

			double p = (xA + xB + xC) / 2.0;
			double areaX = Math.Sqrt (p * (p - xA) * (p - xB) * (p - xC));
			
			p = (yA + yB + yC) / 2.0;
			double areaY = Math.Sqrt (p * (p - yA) * (p - yB) * (p - yC));

			Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
			Console.WriteLine("Area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

			if (areaX > areaY) {
				Console.WriteLine("Maior area: X");
			}
			else {
				Console.WriteLine("Maior area: Y");
			}
		}
	}
}
