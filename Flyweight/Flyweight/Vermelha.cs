using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Vermelha : Tartaruga
    {
        public Vermelha()
        {
            this.condicao = "Tartaruga dentro do casco, ";
            this.acao = "rodando no chão - ";
        }

        public override void Mostra()
        {
            this.cor = "Vermelha";
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
