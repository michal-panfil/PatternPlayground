namespace AbstractFactoryPatern
{
    public class BusinessFactory : IExpenseFactory
    {
        public IUserAcount CreateAccount()
        {
            var acc = new BusinessAccount();
            acc.RegisterUser();
            return acc;

        }

        public IOrder CreateOrder()
        {
            var ord = new MassOrder();
            ord.ProccessOrder();
            return ord;
        }

        public ITranscationDocument CreateProofOfTransaction()
        {
            var transDoc = new Invoice();
            transDoc.GeneratePdf();
            return transDoc;
        }
    }
}
