using PizzaRestaurant._2_FactoryMethodPattern;
using PizzaRestaurant._2_FactoryMethodPattern.Pizzas;

namespace PizzaRestaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza? pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ehan ordered a " + pizza.Name);

            Console.WriteLine("----------------------------------------------");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.Name);
        }
    }
}