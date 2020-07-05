using System.Collections.Generic;

namespace ObserverPattern
{
    partial class Program
    {
        public class WeatherStation : IObservable
        {
            public float WindPower { get; set; }
            public int WindDirection { get; set; }
            private List<IObservator> Observators = new List<IObservator>();
            public void AddObservator(IObservator observator)
            {
                Observators.Add(observator);
            }

            public void Notify()
            {
                Observators.ForEach(o => o.UpdateAndNotify(WindPower,WindDirection));
            }

            public void UpdateWeatherDataAndNotify(float newPower, int newDirection)
            {
                WindDirection = newDirection;
                WindPower = newPower;
                Notify();
            }

           
        }
    }
}
