using Builder.CriadorDeSoldados;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var batalhao23SP = new Batalhao();
            CriadorDeSoldado criadorDeSoldado;
            Soldado soldado;


            /*Soldado Class I*/
            criadorDeSoldado = new CriadorSoldadoClasseI();
            batalhao23SP.ConstruirSoldado(criadorDeSoldado);

            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado criado: {0},{1},{2}", soldado.Arma, soldado.Transporte, soldado.Foco);

            /*Soldado Class II*/
            criadorDeSoldado = new CriadorSoldadoClasseII();
            batalhao23SP.ConstruirSoldado(criadorDeSoldado);

            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado criado: {0},{1},{2}", soldado.Arma, soldado.Transporte, soldado.Foco);

            Console.ReadKey();

        }
    }
}
