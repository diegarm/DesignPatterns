using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    // 3. Concrete Commands
    public class DepositarCommand : ICommand
    {
        private readonly ContaBancaria _conta;
        private readonly decimal _valor;

        public DepositarCommand(ContaBancaria conta, decimal valor)
        {
            _conta = conta;
            _valor = valor;
        }

        public void Execute() => _conta.Depositar(_valor);
        public void Undo() => _conta.Sacar(_valor);
    }
}
