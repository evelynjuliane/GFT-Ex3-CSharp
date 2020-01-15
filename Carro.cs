using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorfismoCSharp
{
	
	public class Carro : Veiculo
	{
		private string modelo { get; set; }
		private int portas { get; set; }
		private string ano { get; set; }

		public Carro(string marca, string modelo, string placa, string cor, int portas, string ano, float km, bool isLigado,
				int litrosCombustivel, int velocidade, double preco)
		{
			this.marca = marca;
			this.modelo = modelo;
			this.placa = placa;
			this.cor = cor;
			this.portas = portas;
			this.ano = ano;
			this.km = km;
			this.isLigado = isLigado;
			this.litrosCombustivel = litrosCombustivel;
			this.velocidade = velocidade;
			this.preco = preco;
		}
		public void Imprime()
		{
		base.Imprime();
			Console.WriteLine("Modelo:" + this.modelo + "Portas:  " + this.portas + "Ano: " + this.ano);
		}
	}
}



