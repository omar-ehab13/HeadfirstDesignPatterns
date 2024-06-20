using PizzaRestaurant._3_AbstractFactoryMethod.Ingredients;
using PizzaRestaurant._3_AbstractFactoryMethod.IngredientsFactory;

namespace PizzaRestaurant._3_AbstractFactoryMethod.Pizzas
{
    public abstract class Pizza
    {
        protected string name = null!;

        protected Dough dough = null!;
        protected Sauce sauce = null!;
        protected List<Veggie> veggies = null!;
        protected Cheese cheese = null!;

        protected IPizaaIngredientFactory ingredientFactory = null!;

        public Pizza(string name, IPizaaIngredientFactory ingredientFactory)
        {
            this.name = name;
            this.ingredientFactory = ingredientFactory;
        }

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string Name { get { return name; } }
    }
}
