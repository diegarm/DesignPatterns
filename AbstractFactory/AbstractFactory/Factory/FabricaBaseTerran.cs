using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public class FabricaBaseTerran : IFabricaBase
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base terran criada");

            RevestimentoBaseTerran revestimento = new RevestimentoBaseTerran();
            revestimento.Composicao();

            EnergiaBaseTerran energia = new EnergiaBaseTerran();
            energia.Composicao();
        }
    }
}
