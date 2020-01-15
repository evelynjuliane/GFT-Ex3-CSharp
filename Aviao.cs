using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorfismoCSharp
{
	public class Aviao : Veiculo
	{
		private string tipo { get; set; }
		private string uso { get; set; }
		public Aviao(string marca, string placa, string cor, float km, bool isLigado,
				int litrosCombustivel, int velocidade, double preco, string tipo, string uso)
		{
			this.marca = marca;
			this.placa = placa;
			this.cor = cor;
			this.km = km;
			this.isLigado = isLigado;
			this.litrosCombustivel = litrosCombustivel;
			this.velocidade = velocidade;
			this.preco = preco;
			this.tipo = tipo;
			this.uso = uso;
		}

		public void Acelerar()
		{
			if (isLigado == false)
			{
				Console.WriteLine("Não é possivel acelerar com o avião desligado!");
			}
			this.velocidade = 1000;
			if (this.litrosCombustivel < 0)
			{
				Console.WriteLine("Veiculo sem combustivel");
			}
			else
			{
				this.litrosCombustivel = -10;
			}
		}

		public void Abastecer(string litrosACombustivel)
		{
			base.Abastecer(Convert.ToInt32(litrosACombustivel));
		}


		public void imprime()
		{
			base.Imprime();
			Console.WriteLine("Tipo: " + tipo + " Uso:" + uso);
		}
	
	}
}
