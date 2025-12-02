using System;
using System.Collections.Generic;
using System.Text;

namespace PublishSubscriber
{
    // 3. Publisher / Subject
    public class ContaBancaria
    {
        private decimal _saldo = 0;
        private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void AdicionarSubscriber(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void RemoverSubscriber(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        private void Notificar(string mensagem)
        {
            foreach (var sub in _subscribers)
            {
                sub.Atualizar(mensagem);
            }
        }

        public void Depositar(decimal valor)
        {
            _saldo += valor;
            Console.WriteLine($"Depósito realizado: R$ {valor}. Saldo: R$ {_saldo}");
            Notificar($"Depósito de R$ {valor} realizado. Saldo atual: R$ {_saldo}");
        }

        public void Sacar(decimal valor)
        {
            if (valor <= _saldo)
            {
                _saldo -= valor;
                Console.WriteLine($"Saque realizado: R$ {valor}. Saldo: R$ {_saldo}");
                Notificar($"Saque de R$ {valor} realizado. Saldo atual: R$ {_saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
                Notificar($"Tentativa de saque de R$ {valor} falhou. Saldo insuficiente.");
            }
        }
    }

}
