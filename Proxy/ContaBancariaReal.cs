using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class ContaBancariaReal : IContaBancaria
    {
        private decimal saldo = 1000m;

        public void Sacar(decimal valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque realizado: R$ {valor}. Novo saldo: R$ {saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito realizado: R$ {valor}. Novo saldo: R$ {saldo}");
        }

        public decimal ConsultarSaldo()
        {
            return saldo;
        }
    }
}
