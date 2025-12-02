using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem diego = new Personagem();

            Aviao aviao = new Aviao();

            IAcao adaptador = new Adapter(aviao);


            Console.WriteLine("Andando");
            diego.Andar("Diego");
            diego.Atirar();
            Console.WriteLine();

            Console.WriteLine("Pegou o avião");
            adaptador.Andar("Diego");
            adaptador.Atirar();
            Console.ReadKey();





        }
    }
}
