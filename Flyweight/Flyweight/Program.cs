using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Flyweight flyweight = new Flyweight();
            string cor = string.Empty;

            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine("Qual a tartaruga deve ser criada  ?");

                cor = Console.ReadLine().ToLower();

                tartaruga = flyweight.GetTartaruga(cor);
                tartaruga.Mostra();

                Console.WriteLine("--------------------");
            }

        }
    }
}
