using PublishSubscriber;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var conta = new ContaBancaria();

        // Subscribers
        var email = new NotificadorEmail("cliente@banco.com");
        var sms = new NotificadorSMS("99999-9999");
        var whatsapp = new NotificadorWhatsApp("88888-8888");

        // Registrar subscribers
        conta.AdicionarSubscriber(email);
        conta.AdicionarSubscriber(sms);
        conta.AdicionarSubscriber(whatsapp);

        // Operações
        conta.Depositar(500);
        conta.Sacar(200);
        conta.Sacar(500); // saldo insuficiente
    }
}
