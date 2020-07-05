using System;

namespace DecoratorPattern
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var myCar = new GlassRoof(new AC(new Car()));

            Console.WriteLine(myCar.About());
            Console.WriteLine(myCar.Price);

            Console.WriteLine("Hello World!");
        }
    }
}
