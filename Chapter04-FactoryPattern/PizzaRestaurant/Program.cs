using PizzaRestaurant._3_AbstractFactoryMethod;
using PizzaRestaurant._3_AbstractFactoryMethod.Pizzas;

namespace PizzaRestaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();

            Pizza? pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ehan ordered a " + pizza.Name);
        }
    }
}