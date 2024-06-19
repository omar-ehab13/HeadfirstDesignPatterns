namespace SimUDuck._3_StrategyDesignPattern.Ducks.FlyingBehaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
