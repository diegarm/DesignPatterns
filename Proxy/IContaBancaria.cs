using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    // Interface comum
    public interface IContaBancaria
    {
        void Sacar(decimal valor);
        void Depositar(decimal valor);
        decimal ConsultarSaldo();
    }
}
