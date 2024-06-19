namespace SimUDuck._3_StrategyDesignPattern.Ducks.QuackBehaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }

}
