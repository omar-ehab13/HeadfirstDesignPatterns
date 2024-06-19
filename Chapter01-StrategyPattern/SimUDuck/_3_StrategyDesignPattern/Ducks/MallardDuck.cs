using SimUDuck._3_StrategyDesignPattern.Ducks.FlyingBehaviors;
using SimUDuck._3_StrategyDesignPattern.Ducks.QuackBehaviors;

namespace SimUDuck._3_StrategyDesignPattern.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new DuckQuack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallarad duck");
        }
    }
}
