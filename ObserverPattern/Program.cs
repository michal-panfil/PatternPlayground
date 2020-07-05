using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObserverPattern
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var station = new WeatherStation();
            station.AddObservator(new AiportOfficeDisplay());
            station.AddObservator(new AiportControllDisplay());

            for (int i = 0; i < 15; i++)
            {
                var rndPower = new Random().Next(0,200);
                var rndDirection = new Random().Next(0,360);
                station.UpdateWeatherDataAndNotify((float)rndPower, rndDirection);
                Thread.Sleep(2000);

            }
        }
    }
}
