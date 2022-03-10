using System; 

namespace Course {
	class Program {
		static void Main(string [] args) {

			Console.WriteLine("Digite tres numeros:");
			int n1 = int.Parse(Console.ReadLine());
			int n2 = int.Parse(Console.ReadLine());
			int n3 = int.Parse(Console.ReadLine());

			if (n1 > n2 && n1 > n3) {
				Console.WriteLine("Maior = " + n1);
			}

			else if (n2 > n3) {
				Console.WriteLine("Maior = " + n2);
			}

			else {
				Console.WriteLine("Maior = " + n3);
			}

		}
	}
}
