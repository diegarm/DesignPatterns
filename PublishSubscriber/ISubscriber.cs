using System;
using System.Collections.Generic;
using System.Text;

namespace PublishSubscriber
{
    // 1. Observer / Subscriber
    public interface ISubscriber
    {
        void Atualizar(string mensagem);
    }
}
