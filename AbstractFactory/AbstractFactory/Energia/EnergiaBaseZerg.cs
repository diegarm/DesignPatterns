using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class EnergiaBaseZerg : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia plena Terra");
        }
    }
}
