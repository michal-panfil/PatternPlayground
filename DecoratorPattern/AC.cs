using System;

namespace DecoratorPattern
{
    public class AC : AdditionalDecorator
    {
        public AC(IVehicle veh)
        {
            this.Vehicle = veh;
        }

        public IVehicle Vehicel { get; }

        public override string About()
        {
            return this.Vehicle.About() +" Air Condition";
        }

        public override int Price => this.Vehicle.Price + 2500;
        public void TurnOnAC()
        {
            Console.WriteLine("AC is on");
        }
    }
}
