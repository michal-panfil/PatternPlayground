using System;

namespace AbstractFactoryPatern
{
    public class PersonalAccount : IUserAcount
    {
        public void RegisterUser()
        {
            Console.WriteLine("Presonal Account was crated");
        }
    }
}
