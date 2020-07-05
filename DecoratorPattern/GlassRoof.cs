namespace DecoratorPattern
{
    public class GlassRoof : AdditionalDecorator
    {
        IVehicle Vehicel;
        public GlassRoof(IVehicle veh)
        {
            Vehicle = veh;
        }
        public override string About()
        {
            return this.Vehicle.About() + " glass roof";
        }

        public override int Price => this.Vehicle.Price + 3500;

    }
}
