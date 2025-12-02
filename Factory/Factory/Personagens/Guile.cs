using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Personagens
{
    class Guile : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Guile");
        }
    }
}
