namespace PublishSubscriber
{
    public class NotificadorWhatsApp : ISubscriber
    {
        private string _numeroTelefone;
        public NotificadorWhatsApp(string numeroTelefone) => _numeroTelefone = numeroTelefone;
        public void Atualizar(string mensagem)
        {
            Console.WriteLine($"[WhatsApp para {_numeroTelefone}] {mensagem}");
        }
    }
}
