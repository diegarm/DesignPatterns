using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o jogo");

            Bola jogador1 = Bola.GetInstancia;
            jogador1.Mensagem("Jogador 1 Inicia o jogo");

            Bola jogador2 = Bola.GetInstancia;
            jogador2.Mensagem("Jogador 2 toma a bola");


        }
    }
}
