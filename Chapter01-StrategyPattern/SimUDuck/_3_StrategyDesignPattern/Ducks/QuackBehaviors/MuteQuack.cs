namespace SimUDuck._3_StrategyDesignPattern.Ducks.QuackBehaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }

}
