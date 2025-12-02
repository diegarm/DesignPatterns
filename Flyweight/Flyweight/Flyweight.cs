using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Flyweight
    {
        private Dictionary<string, Tartaruga> listaTartarugas = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga tartaruga = null;

            if (listaTartarugas.ContainsKey(cor))
            {
                tartaruga = listaTartarugas[cor];
            }
            else
            {
                switch (cor)
                {
                    case "azul": tartaruga = new Azul(); break;
                    case "verde": tartaruga = new Verde(); break;
                    case "laranja": tartaruga = new Laranja(); break;
                    case "vermelha": tartaruga = new Vermelha(); break;
                }

                listaTartarugas.Add(cor, tartaruga);

            }

            return tartaruga;
        }
    }
}
