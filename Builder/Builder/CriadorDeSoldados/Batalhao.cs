using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.CriadorDeSoldados
{
    public class Batalhao 
    {
        public void ConstruirSoldado(CriadorDeSoldado criador)
        {
            criador.Arma();
            criador.Foco();
            criador.Transporte();
        }

    }
}
