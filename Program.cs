using System;

namespace PolimorfismoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
			Aviao aviao = new Aviao("BBB", "GGG-22", "AZUL", 30000000, false, 20, 100, 100000000, "Comercial", "privado");

			aviao.Acelerar();
			aviao.Abastecer(100);

			Carro carro = new Carro("Fiat", "Uno", "EEE-222", "Preto", 5, "2014", 250000, true, 100, 0, 250000);

			carro.Acelerar();
			carro.Abastecer(100);
			carro.Abastecer(10);

			Caminhao caminhao = new Caminhao("VOLVO", "AAA-222", "AZUL", 2000000, true, 200, 0, 10000);

			caminhao.Acelerar();
			caminhao.Abastecer(100);
			caminhao.Abastecer(10);

			carro.Imprime();
			caminhao.Imprime();
			aviao.imprime();

		}
	}
}
