using System;

namespace ObserverPattern
{
    partial class Program
    {
        public class AiportControllDisplay : IObservator, IDisplayable
        {
            public float WindPower { get; set; }
            public int WindDirection { get; set; }

            public void Display()
            {
                Console.WriteLine("Control Display");
                Console.WriteLine($"Wind direction : {WindDirection} , Wind power: {WindPower}" );
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
