using StarbuzzCoffee._2_DecoratorPattern;
using StarbuzzCoffee._2_DecoratorPattern.Beverages;
using StarbuzzCoffee._2_DecoratorPattern.Condiments;

namespace StarbuzzCoffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beverage darkRoast = new DarkRoast();
            //darkRoast.SetMocha();
            //darkRoast.SetWhip();

            //Console.WriteLine(darkRoast.Cost());

            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());
        }
    }
}