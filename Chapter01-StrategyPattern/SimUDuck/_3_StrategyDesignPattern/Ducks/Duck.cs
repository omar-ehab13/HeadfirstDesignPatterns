using SimUDuck._3_StrategyDesignPattern.Ducks.FlyingBehaviors;
using SimUDuck._3_StrategyDesignPattern.Ducks.QuackBehaviors;

namespace SimUDuck._3_StrategyDesignPattern.Ducks
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior { get; set; }
        protected IQuackBehavior quackBehavior { get; set; }

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }
    }
}
