namespace Proxy
{
    public class ContaBancariaProxy : IContaBancaria
    {
        private readonly ContaBancariaReal _contaReal;
        private readonly string _usuario;
        private readonly string _senha;

        public ContaBancariaProxy(string usuario, string senha)
        {
            _usuario = usuario;
            _senha = senha;
            _contaReal = new ContaBancariaReal();
        }

        // Verificação simples de autenticação
        private bool Autenticar()
        {
            return _usuario == "cliente" && _senha == "1234";
        }

        public void Sacar(decimal valor)
        {
            if (!Autenticar())
            {
                Console.WriteLine("Acesso negado! Usuário ou senha incorretos.");
                return;
            }

            Console.WriteLine("[Proxy] Autenticação OK. Processando saque...");
            _contaReal.Sacar(valor);
        }

        public void Depositar(decimal valor)
        {
            if (!Autenticar())
            {
                Console.WriteLine("Acesso negado! Usuário ou senha incorretos.");
                return;
            }

            Console.WriteLine("[Proxy] Autenticação OK. Processando depósito...");
            _contaReal.Depositar(valor);
        }

        public decimal ConsultarSaldo()
        {
            if (!Autenticar())
            {
                Console.WriteLine("Acesso negado! Usuário ou senha incorretos.");
                return 0;
            }

            Console.WriteLine("[Proxy] Autenticação OK. Consultando saldo...");
            return _contaReal.ConsultarSaldo();
        }
    }
}
