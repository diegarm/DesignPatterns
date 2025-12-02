using Proxy;
using System;



// Programa de teste
public class Program
{
    public static void Main(string[] args)
    {
        IContaBancaria conta = new ContaBancariaProxy("cliente4", "1234");

        Console.WriteLine("Saldo atual: R$ " + conta.ConsultarSaldo());
        conta.Sacar(200);
        conta.Depositar(150);
    }
}
