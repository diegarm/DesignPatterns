using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.CriadorDeSoldados
{
    public class CriadorSoldadoClasseI : CriadorDeSoldado
    {
        public CriadorSoldadoClasseI()
        {
            _soldado = new SoldadoPMClasseI();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Calibre 40");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Resposta Rápida, 3 anos de experiência");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Blazer");
        }
    }
}
