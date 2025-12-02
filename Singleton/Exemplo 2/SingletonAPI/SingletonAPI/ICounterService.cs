namespace SingletonAPI
{
    public interface ICounterService
    {
        int Valor { get; }
        void Increment();
        void Decrement();
    }
}
