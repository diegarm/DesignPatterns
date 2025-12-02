using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public class FabricaBaseZerg : IFabricaBase
    {
        public FabricaBaseZerg()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Zerg criada");

            RevestimentoBaseZerg revestimento = new RevestimentoBaseZerg();
            EnergiaBaseZerg energia = new EnergiaBaseZerg();

            revestimento.Composicao();
            energia.Composicao();

        }
    }
}
