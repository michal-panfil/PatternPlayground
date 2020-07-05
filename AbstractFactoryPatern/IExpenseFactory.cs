namespace AbstractFactoryPatern
{
    public interface IExpenseFactory
    {
        ITranscationDocument CreateProofOfTransaction();
        IUserAcount CreateAccount();
        IOrder CreateOrder();
    }
}
