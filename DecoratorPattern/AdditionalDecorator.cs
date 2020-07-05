namespace DecoratorPattern
{
    public abstract class AdditionalDecorator :IVehicle
    {
        public IVehicle Vehicle;

        public abstract string About();


        public abstract int Price { get; }
    }
}
