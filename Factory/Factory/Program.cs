using Factory.Factory;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factory = new FactoryMethod();

            Console.WriteLine("Escolha o personagem do Street Figther: Ryu, Ken ou Guile");
            Console.WriteLine();
            var escolha = Console.ReadLine();

            IPersonagem personagem = factory.EscolherPersonagem(escolha);
            Console.WriteLine();
            Console.Write("Você vai jogar com: ");
            personagem.Escolhido();
            Console.ReadKey();

        }
    }
}
