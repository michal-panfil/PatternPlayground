namespace StrategyPattern
{
    public class PaymentModule
    {
        private IPaymentStrategy PaymentStrategy { get; set; }
        public PaymentModule(IPaymentStrategy paymentStategy)
        {
            this.PaymentStrategy = paymentStategy;
        }
        public string payForService(int amount)
        {
           var paied = PaymentStrategy.Pay(amount);

            return paied ? "You paied. Thank you" : "semething went wrong";
           
            }
        }
    }
