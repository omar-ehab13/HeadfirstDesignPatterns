using SimUDuck._3_StrategyDesignPattern.Ducks.FlyingBehaviors;
using SimUDuck._3_StrategyDesignPattern.Ducks.QuackBehaviors;

namespace SimUDuck._3_StrategyDesignPattern.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Rubber duck");
        }
    }
}
