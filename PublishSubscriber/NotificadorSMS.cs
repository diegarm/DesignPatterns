using System;
using System.Collections.Generic;
using System.Text;

namespace PublishSubscriber
{
    public class NotificadorSMS : ISubscriber
    {
        private string _telefone;
        public NotificadorSMS(string telefone) => _telefone = telefone;

        public void Atualizar(string mensagem)
        {
            Console.WriteLine($"[SMS para {_telefone}] {mensagem}");
        }
    }
}
