namespace ObserverPattern
{
    partial class Program
    {
        public interface IObservable
        {
            void AddObservator(IObservator observator);
            void Notify();

        }
    }
}
