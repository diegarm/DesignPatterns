using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class BancoInvoker
    {
        private readonly Stack<ICommand> _historico = new Stack<ICommand>();

        public void ExecutarComando(ICommand comando)
        {
            comando.Execute();
            _historico.Push(comando);
        }

        public void DesfazerUltimo()
        {
            if (_historico.Count > 0)
            {
                var comando = _historico.Pop();
                comando.Undo();
            }
            else
            {
                Console.WriteLine("Nenhum comando para desfazer.");
            }
        }
    }
}
