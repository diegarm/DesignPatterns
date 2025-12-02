using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class NuvemConcreta : NuvemMolde
    {
        private string cor_prenchimento;
        private string cor_contorno;

        public NuvemConcreta(string preenchimento, string contorno)
        {
            this.cor_contorno = contorno;
            this.cor_prenchimento = preenchimento;
        }

        public override NuvemMolde Clone()
        {
            Console.WriteLine("Nuvem Clonada tem contorno " + this.cor_contorno + " e preenchimento " + this.cor_prenchimento);
            return this.MemberwiseClone() as NuvemMolde;            
        }
    }
}
