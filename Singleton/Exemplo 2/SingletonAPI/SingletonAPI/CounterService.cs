namespace SingletonAPI
{
    public class CounterService : ICounterService
    {
        private int _valor;
        public int Valor => _valor;
        public void Increment()
        {
            _valor++;
        }
        public void Decrement()
        {
            _valor--;
        }
    }
}
