using System;
using System.Globalization;

// Exercicio de fixacao: Em um novo programa, inicie as seguintes variaveis:

namespace Course {
	class Program {
		static void Main(string [] args) {

		string produto1 = "Computador";
		string produto2 = "Mesa de escritorio";

		byte idade = 30;
		int codigo = 5290;
		char genero = 'M';

		double preco1 = 2100.0;
		double preco2 = 650.50;
		double medida - 53.234567;

// Em seguida, usando os valores das variaveis, produza a seguinte saida na tela do console:
// Produtos: Computador, cuja o preco $ 2100,00
//           Mesa de escritorio, cujo preco $ 650,50
// Registro: 30 anos de idade, codigo 5290 e genero: M
// Medida com todas as casas decimais, medida com tres casas e separador decimal invariant culture

		Console.WriteLine("Produtos:");
		Console.WriteLine($"O {produto1} cujo o preco no momento: {preco1:F2}");
		Console.WriteLine($"O {produto2} cujo o preco no momento: {preco2:F2}");
		Console.WriteLine($"O homem {genero}, tem {idade} anos de idade e o codigo {codigo}.");
		Console.WriteLine($"As medidas sao: {medida:F8}, {medida:F3} e " + media.ToString("F3", CultureInfor.InvariantCulture));

		}
	}
}
