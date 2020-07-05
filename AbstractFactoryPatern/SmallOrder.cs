using System;

namespace AbstractFactoryPatern
{
    public class SmallOrder : IOrder
    {
        public void ProccessOrder()
        {
            Console.WriteLine("Small Order was created");
        }
    }
}
