using StarbuzzCoffee._1_InitialDesign;

namespace StarbuzzCoffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage darkRoast = new DarkRoast();
            darkRoast.SetMocha();
            darkRoast.SetWhip();

            Console.WriteLine(darkRoast.Cost());
        }
    }
}