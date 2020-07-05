namespace FactoryPattern
{
    public class CashReward : IReward
    {
         public string Name { get; set; }
        private int Value { get; set; }

        public CashReward(int value, string name)
        {
            Value = value;
            Name = Name;
        }

        public int getRewardValue() {
            return Value;
        }

    }
}
