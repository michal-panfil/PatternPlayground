namespace DecoratorPattern
{
    public class Car : IVehicle
    {
        public  string About()
        {
            return "personal car";
        }

        public int Price => 40000;
    }
}
