using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public abstract class Tartaruga
    {
        protected string condicao;
        protected string acao;
        public string cor { get; set; }

        public abstract void Mostra();

    }
}
