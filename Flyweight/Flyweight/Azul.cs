using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Azul : Tartaruga
    {
        public Azul()
        {
            this.condicao = "Tartaruga dentro do casco, ";
            this.acao = "rodando no chão - ";
        }

        public override void Mostra()
        {
            this.cor = "Azul";
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
