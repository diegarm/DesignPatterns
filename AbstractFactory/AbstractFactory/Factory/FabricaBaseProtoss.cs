using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public class FabricaBaseProtoss : IFabricaBase
    {
        public FabricaBaseProtoss()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Protoss criada");

            RevestimentoBaseProtoss revestimento = new RevestimentoBaseProtoss();
            EnergiaBaseProtoss energia = new EnergiaBaseProtoss();

            revestimento.Composicao();
            energia.Composicao();

        }
    }
}
