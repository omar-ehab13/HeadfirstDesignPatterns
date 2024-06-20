using PizzaRestaurant._3_AbstractFactoryMethod.IngredientsFactory;

namespace PizzaRestaurant._3_AbstractFactoryMethod.Pizzas
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(string name, IPizaaIngredientFactory ingredientFactory)
            : base(name, ingredientFactory)
        {
        }

        public override void Prepare()
        {
            this.dough = ingredientFactory.CreateDough();
            this.sauce = ingredientFactory.CreateSauce();
            this.cheese = ingredientFactory.CreateCheese();

            Console.WriteLine("Preparing " + this.name);
            Console.WriteLine("Tossing " + this.dough.GetName());
            Console.WriteLine("Adding " + this.sauce.GetName());
            Console.WriteLine("Adding " + this.cheese.GetName());
        }
    }
}
