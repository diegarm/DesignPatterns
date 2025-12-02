using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.CriadorDeSoldados
{
    public class CriadorSoldadoClasseII : CriadorDeSoldado
    {
        public CriadorSoldadoClasseII()
        {
            _soldado = new SoldadoPMClasseII();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Calibre 38");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Soldado em treinamento, sem muito foco");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Corsa modelo 2002");
        }
    }
}
