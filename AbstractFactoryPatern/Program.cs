using System;
using System.Collections.Generic;
using System.Dynamic;

namespace AbstractFactoryPatern
{
    class Program
    {
        static void Main(string[] args)
        {

            var factoryList = new List<IExpenseFactory>();
            factoryList.Add(new IndividualFactory());
            factoryList.Add(new BusinessFactory());

            foreach (var factory in factoryList)
            {
                Console.WriteLine($"Factory Type{factory.GetType()}");
                factory.CreateAccount();
                factory.CreateOrder();
                factory.CreateProofOfTransaction();
                Console.WriteLine();
                Console.WriteLine("==============");
            }

        }
    }
}
