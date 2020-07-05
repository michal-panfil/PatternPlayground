using System;

namespace AbstractFactoryPatern
{
    public class BusinessAccount : IUserAcount
    {
        public void RegisterUser()
        {
            Console.WriteLine("Presonal Account was crated");
        }
    }
}
