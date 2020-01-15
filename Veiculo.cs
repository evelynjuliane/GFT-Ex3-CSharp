using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorfismoCSharp
{

	public abstract class Veiculo
		{

		protected string marca { get; set; }
		protected string placa { get; set; }
		protected string cor { get; set; }
		protected float km { get; set; }
		protected bool isLigado { get; set; }
		protected int litrosCombustivel { get; set; }
		protected int velocidade { get; set; }
		protected double preco { get; set; }


		public void Acelerar()
		{
			if (isLigado == false)
			{
				Console.WriteLine("Não é possivel acelerar com o veiculo desligado!");
			}
			this.velocidade = 15;
			if (this.litrosCombustivel < 0)
			{
				Console.WriteLine("Veiculo sem combustivel");
			}
			else
			{
				this.litrosCombustivel = -4;
			}
		}
		public void Abastecer(int litrosACombustivel)
		{
			if (this.litrosCombustivel < 100)
			{
				this.litrosCombustivel = litrosACombustivel;
			}
			else
			{
				Console.WriteLine("O Veiculo está com o tanque cheio!");
			}
		}
		public void Imprime()
			{
				Console.WriteLine("Marca:" + this.marca + "Placa:" + this.placa + "Cor:" + this.cor + "Km:" + this.km + "Status:" + this.isLigado
					+ "Litros de Combutível:" + this.litrosCombustivel + "Velocidade:" + this.velocidade + "Preço:" + this.preco);


			}
	}

}