using System;

namespace ObserverPattern
{
    partial class Program
    {
        public class AiportOfficeDisplay : IObservator, IDisplayable
        {
            public float WindPower { get; set; }
            public int  WindDirection { get; set; }

            public void Display()
            {
                Console.WriteLine("Airport Office Display");
                Console.WriteLine($"Wind direction : {WindDirection} , Wind power: {WindPower}");
            }

            public void UpdateAndNotify(float newWindPower, int newWindDirection)
            {
                WindPower = newWindPower;
                WindDirection = newWindDirection;
                Display();
            }
        }
    }
}
