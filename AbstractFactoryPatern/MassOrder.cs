using System;

namespace AbstractFactoryPatern
{
    public class MassOrder : IOrder
    {
        public void ProccessOrder()
        {
            Console.WriteLine("Mass Order was created");
        }
    }
}
