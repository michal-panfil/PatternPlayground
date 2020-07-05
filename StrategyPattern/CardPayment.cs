namespace StrategyPattern
{
    public class CardPayment : IPaymentStrategy
    {
        public bool Pay(int amont)
        {
            return true;
        }
    }
    }
