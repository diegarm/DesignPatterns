using Bridge.Cores;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Bridge bridge = new Bridge();
            Random random = new Random();

            void Sortear()
            {
                if (random.Next(2) == 1)
                    bridge.forma_solicitada = new FormaT();
                else
                    bridge.forma_solicitada = new FormaU();


                if (random.Next(1, 3) == 1)
                    bridge.forma_solicitada.ICor = new Verde();
                else if (random.Next(2, 3) == 2)
                    bridge.forma_solicitada.ICor = new Laranja();
                else
                    bridge.forma_solicitada.ICor = new Azul();

            }

            Console.WriteLine("Pressione ENTER para enviar uma forma");

            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey();

                if (input.KeyChar == 13)
                    Sortear();

                Console.WriteLine();
                bridge.ExibeQualFormaEstaDescendoNaTela();

            }
        


        }
    }
}
