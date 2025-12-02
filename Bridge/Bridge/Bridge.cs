using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Bridge
    {
        public IForma forma_solicitada { get; set; }

        public void ExibeQualFormaEstaDescendoNaTela()
        {
            Console.WriteLine(forma_solicitada.Descer());
        }
    }
}
