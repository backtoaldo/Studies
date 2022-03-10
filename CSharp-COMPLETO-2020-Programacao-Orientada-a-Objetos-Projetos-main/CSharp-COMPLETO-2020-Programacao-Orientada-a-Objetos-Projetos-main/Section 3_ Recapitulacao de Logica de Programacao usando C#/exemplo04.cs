using System;

namespace Course {
	class Program {
		static void Main(string[] args) {

			int n1 = int.Parse (Console.ReadLine());
			char genero = char.Parse (Console.ReadLine());
			double n2 = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

			string[] vet = Console.ReadLine().Split(' ');
			string nome = vet[0];
			char sexo = char.Parse (vet[1]);
			int idade = int.Parse (vet[2]);
			double altura = double.Parse (veto[3], CultureInfo.InvariantCulture);			
			
			Console.WriteLine("Voce digitou:");
			Console.WriteLine(n1);
			Console.WriteLine(genero);
			Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

			Console.WriteLine(nome);
			Console.WriteLine(sexo);
			Console.WriteLine(idade);
			Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

		}
	}
}
