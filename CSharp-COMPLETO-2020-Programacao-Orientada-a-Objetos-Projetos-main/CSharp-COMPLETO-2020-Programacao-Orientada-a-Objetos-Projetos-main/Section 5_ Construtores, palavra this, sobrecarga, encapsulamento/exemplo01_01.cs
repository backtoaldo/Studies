using System;
using System.Globalization
using System.Collections.Generic;
using System.Text;

namespace Course {
	class Produto {

		public string Nome;
		public double Preco;
		public int Quantidade;

		public Produto(string nome, double preco, int quantidade) {
			Nome = nome;
			Preco = preco;
			Quantidade = quantidade;
		}

		public Produto(string nome, double preco) {
			Nome = nome;
			Preco = preco;
			//Quantidade = 0;
		}

		public double ValorTotalEmEstoque() {
			return Preco * Quantidade;			
		}
		
		public void AdicionarProdutos(int quantidade) {
			//Quantidade = Quantidade + quantidade;
			Quantidade += quantidade;
		}

		public void RemoverProdutos(int quantidade){
			//Quantidade = Quantidade - quantidade;
			Quantidade -= quantidade;
		}

		public override string ToString() {
			return Nome + ", R$ " 
			+ Preco.ToString("F2", CultureInfo.InvariantCulture)
			+ ", "
			+ Quantidade
			+ " unidades, Total: R$ "
			+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}

	}
}
