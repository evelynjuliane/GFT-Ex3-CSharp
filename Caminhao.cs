using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorfismoCSharp
{
    public class Caminhao : Veiculo
    {
        public Caminhao(string marca, string placa, string cor, float km, bool isLigado,
					int litrosCombustivel, int velocidade, double preco)
		{ 
				this.marca = marca;
				this.placa = placa;
				this.cor = cor;
				this.km = km;
				this.isLigado = isLigado;
				this.litrosCombustivel = litrosCombustivel;
				this.velocidade = velocidade;
				this.preco = preco;
				
			}

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
		public void Abastecer(float litrosACombustivel)
		{
			if (this.litrosCombustivel < 400)
			{
				this.litrosCombustivel = (int)litrosACombustivel;
			}
			else
			{
				Console.WriteLine("O Veiculo está com o tanque cheio!");
			}

		}

		public void Imprime()
			{
				base.Imprime();
				
		}

		
	
    }
}
