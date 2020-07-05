namespace StrategyPattern
{
    public class TransferPayment : IPaymentStrategy
    {
        public bool Pay(int amont)
        {
            return true;
        }
    }
    }
