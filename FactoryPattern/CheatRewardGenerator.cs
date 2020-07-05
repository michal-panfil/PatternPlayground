namespace FactoryPattern
{
    partial class Program
    {
        public class CheatRewardGenerator : IRewardGenarator
        {
            public IReward Drawing(int rnd)
            {
                return new CashReward(100, "Cool Price");
            }
        }
    }
}
