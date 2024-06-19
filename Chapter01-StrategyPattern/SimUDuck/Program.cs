using SimUDuck._3_StrategyDesignPattern.Ducks;

namespace SimUDuck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();

            mallard.PerformQuack();
            mallard.PerformFly();
        }
    }
}