namespace SimUDuck._3_StrategyDesignPattern.Ducks.QuackBehaviors
{
    public class DuckQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }

}
