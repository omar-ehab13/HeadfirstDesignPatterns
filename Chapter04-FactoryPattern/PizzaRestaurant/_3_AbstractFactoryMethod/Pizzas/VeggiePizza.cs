using PizzaRestaurant._3_AbstractFactoryMethod.IngredientsFactory;

namespace PizzaRestaurant._3_AbstractFactoryMethod.Pizzas
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza(string name, IPizaaIngredientFactory ingredientFactory)
            : base(name, ingredientFactory)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + this.name);
            this.dough = ingredientFactory.CreateDough();
            this.sauce = ingredientFactory.CreateSauce();
            this.cheese = ingredientFactory.CreateCheese();
            this.veggies = ingredientFactory.CreateVeggies();
        }
    }
}
