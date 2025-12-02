using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Bola
    {
        private static Bola instancia = null;

        public static Bola GetInstancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Bola();
                    Console.WriteLine("Bola criada");
                }
                return instancia;
            }
        }

        public void Mensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
