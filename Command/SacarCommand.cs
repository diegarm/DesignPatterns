using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class SacarCommand : ICommand
    {
        private readonly ContaBancaria _conta;
        private readonly decimal _valor;

        public SacarCommand(ContaBancaria conta, decimal valor)
        {
            _conta = conta;
            _valor = valor;
        }

        public void Execute() => _conta.Sacar(_valor);
        public void Undo() => _conta.Depositar(_valor);
    }
}
