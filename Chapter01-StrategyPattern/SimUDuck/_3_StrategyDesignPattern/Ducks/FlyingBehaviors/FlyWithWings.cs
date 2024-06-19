namespace SimUDuck._3_StrategyDesignPattern.Ducks.FlyingBehaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}
