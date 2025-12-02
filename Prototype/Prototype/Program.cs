using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorNuvens gereciador = new GerenciadorNuvens();
            gereciador["padrao"] = new NuvemConcreta("branco", "azul");
            gereciador["personalizada"] = new NuvemConcreta("branco", "laranja");

            NuvemConcreta um = gereciador["padrao"].Clone() as NuvemConcreta;
            NuvemConcreta dois = gereciador["padrao"].Clone() as NuvemConcreta;
            NuvemConcreta tres = gereciador["personalizada"].Clone() as NuvemConcreta;

            Console.ReadKey();

        }
    }
}
