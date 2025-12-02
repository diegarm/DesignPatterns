using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    // 2. Receiver
    public class ContaBancaria
    {
        public decimal Saldo { get; private set; } = 1000m;

        public void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito: R$ {valor}. Saldo atual: R$ {Saldo}");
        }

        public void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque: R$ {valor}. Saldo atual: R$ {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
    }
}
