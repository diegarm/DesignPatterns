using Command;

public class Program
{
    public static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();
        BancoInvoker banco = new BancoInvoker();

        // Executar comandos
        banco.ExecutarComando(new DepositarCommand(conta, 200));
        banco.ExecutarComando(new SacarCommand(conta, 100));

        // Desfazer último comando
        Console.WriteLine("\nDesfazendo último comando...");
        banco.DesfazerUltimo();

        // Desfazer outro comando
        Console.WriteLine("\nDesfazendo outro comando...");
        banco.DesfazerUltimo();
    }
}
