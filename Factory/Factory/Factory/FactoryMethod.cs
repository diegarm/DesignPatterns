using Factory.Personagens;

namespace Factory.Factory
{
    public class FactoryMethod
    {
        public IPersonagem EscolherPersonagem(string sPersonagem)
        {
            switch (sPersonagem)
            {
                case "Ryu": return new Ryu();
                case "Ken": return new Ken();
                case "Guile": return new Guile();
                default: return null;                    
            }
        }
    }
}
