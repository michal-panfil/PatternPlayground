namespace StrategyPattern
{
    public class CashPayment : IPaymentStrategy
    {
        public bool Pay(int amont)
        {
            return true;
        }
    }
    }
