namespace AbstractFactoryPatern
{
    public class IndividualFactory : IExpenseFactory
    {
        public IUserAcount CreateAccount()
        {
            var acc = new PersonalAccount();
            acc.RegisterUser();
            return acc;
        }

        public IOrder CreateOrder()
        {
            var ord = new SmallOrder();
            ord.ProccessOrder();
            return ord;
        }

        public ITranscationDocument CreateProofOfTransaction()
        {
            var tranDoc = new Recipt();
            tranDoc.GeneratePdf();
            return tranDoc;
        }
    }
}
