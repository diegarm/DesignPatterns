using System;
public sealed class Logger
{
    // Lazy garante criação sob demanda e segurança em multithreading
    private static readonly Lazy<Logger> _instance =
        new Lazy<Logger>(() => new Logger());

    // A instância pública
    public static Logger Instance => _instance.Value;

    // Construtor privado para evitar "new"
    private Logger()
    {
        // Inicialização interna se necessário
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}