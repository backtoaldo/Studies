//Uso da palavra this
//Referenciar outro construtor em um construtor
using System.Globalization;

namespace Course {
	class Produto {
	
		public string Nome;
		public double Preco;
		public int Quantidade;
		
		public Produto() {
		Quantidade = 0;
		}

		public Produto(string nome, double preco) : this() {
		Nome = nome;
		Preco = preco;
		}

		public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
		Quantidade = quantidade;
		}
			(...)
