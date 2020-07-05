using System;
using System.IO;

namespace FactoryPattern
{
    partial class Program
    {
        public class FairRewardGenerator : IRewardGenarator
        {
            public  IReward Drawing(int rnd) {
                
                Console.WriteLine(rnd);
                var priceValue = 0;
                var priceName = "";
               if(rnd < 5)
                {
                    priceValue = 100;
                    priceName = "small price";
                }
               else if(rnd < 8)
                {
                    priceValue = 300;
                    priceName = "midle price";
                }
                else if (rnd < 11)
                {
                    priceValue = 500;
                    priceName = "big price";
                }
                else
                {
                    throw new Exception();
                }
                return new CashReward(priceValue, priceName);
            }
        }
    }
}
