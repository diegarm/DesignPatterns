using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class FormaT : IForma
    {
        public ICor ICor { get; set; }

        public string Descer()
        {
            return "T - " + ICor.Cor();
        }
    }
}
