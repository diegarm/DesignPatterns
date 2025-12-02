using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class RevestimentoBaseZerg : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestica cor vermelha");
        }
    }
}
