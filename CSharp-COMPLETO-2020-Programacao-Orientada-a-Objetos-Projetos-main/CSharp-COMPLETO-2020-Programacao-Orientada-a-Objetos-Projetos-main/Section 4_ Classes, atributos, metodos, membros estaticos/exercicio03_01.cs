using System;

namespace Course {
	class Triangulo {

		public double A;
		public double B;
		public double C;

		public double Area() {
			double p = (A + B + C) / 2.0;
			//double raiz = Math.Sqrt (p * (p - A) * (p - B) * (p - C));
			//return raiz;
			//FORMA MAIS PRATICA:
			return Math.Sqrt (p * (p - A) * (p - B) * (p - C));

		}
	}
}
