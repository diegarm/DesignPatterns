using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory
{
    public class EnergiaBaseTerran : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia Mecânica");
        }
    }
}
