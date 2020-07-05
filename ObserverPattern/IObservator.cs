namespace ObserverPattern
{
    partial class Program
    {
        public interface IObservator
        {
            void UpdateAndNotify(float windPower, int windDirection);
        }
    }
}
