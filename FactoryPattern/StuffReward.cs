namespace FactoryPattern
{
    public class StuffReward : IReward
    {
        public string Name { get; set; }
        private int Value { get; set; }

        public StuffReward(int value, string name)
        {
            Value = value;
            Name = Name;
        }

        public int getRewardValue()
        {
            return Value;
        }

    }
}
