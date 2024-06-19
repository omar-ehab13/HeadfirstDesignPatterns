using SimUDuck._3_StrategyDesignPattern.Ducks.FlyingBehaviors;
using SimUDuck._3_StrategyDesignPattern.Ducks.QuackBehaviors;

namespace SimUDuck._3_StrategyDesignPattern.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Decoy duck");
        }
    }
}
