using System;
using System.Collections.Generic;
using System.Text;

namespace PublishSubscriber
{
    // 2. Concrete Subscribers
    public class NotificadorEmail : ISubscriber
    {
        private string _email;
        public NotificadorEmail(string email) => _email = email;

        public void Atualizar(string mensagem)
        {
            Console.WriteLine($"[Email para {_email}] {mensagem}");
        }
    }
}
