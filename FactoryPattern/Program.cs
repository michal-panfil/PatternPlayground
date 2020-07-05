using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    partial class Program
    {
        static void Main(string[] args)
        {
            playAtCassino(1000);
            Console.ReadKey();
        }
        private static void playAtCassino(int tryCount)
        {
            var machine = new GamingMachine(new FairRewardGenerator());
            for (int i = 0; i < tryCount; i++)
            {
                var currentPlayResult = machine.Play();
                Console.WriteLine(currentPlayResult);
            }
        }
    }
}
