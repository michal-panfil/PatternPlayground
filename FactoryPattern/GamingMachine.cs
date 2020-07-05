using System;

namespace FactoryPattern
{
    partial class Program
    {
        public class GamingMachine {
            private Random RandomNbr { get; set; }
            private IRewardGenarator RewardGenerator { get; set; }

            public GamingMachine(IRewardGenarator generator)
            {
                RandomNbr = new Random();
                RewardGenerator = generator;
            }
            public string Play() {

                if((RandomNbr.Next(10) + DateTime.Now.Second) % 2 == 0)
                {
                    var reword = RewardGenerator.Drawing(RandomNbr.Next(10));
                    return $"You WON {reword.Name} : {reword.getRewardValue()}";
                }

                return "you loose";
            }
            }
    }
}
