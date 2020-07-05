using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentList = new List<PaymentModule> {
            new PaymentModule(new CardPayment()),
             new PaymentModule(new TransferPayment()),
             new PaymentModule(new CashPayment())
             };

            paymentList.ForEach(p => Console.WriteLine(p.payForService(100)) );
        Console.ReadLine();
            
        }
    }
}
