using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class RevestimentoBaseTerran : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida cor verde");
        }
    }
}
