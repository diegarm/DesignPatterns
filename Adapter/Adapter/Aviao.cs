using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Aviao
    {
        public void Voar(string personagem)
        {
            Console.WriteLine(personagem + " Voou para frente!");
        }

        public void SoltarMissil()
        {
            Console.WriteLine("Soltou missil no jogo!");
        }
    }
}
