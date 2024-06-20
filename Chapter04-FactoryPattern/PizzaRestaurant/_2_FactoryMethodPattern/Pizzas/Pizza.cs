namespace PizzaRestaurant._2_FactoryMethodPattern.Pizzas
{
    public abstract class Pizza
    {
        protected string name = null!;
        protected string dough = null!;
        protected string sauce = null!;
        protected List<string> toppings = new List<string>();

        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {name}");
            Console.WriteLine($"Tossing dough {dough}");
            Console.WriteLine($"Adding sauce {sauce}");
            Console.WriteLine($"Adding toppings: ");
            foreach (var topping in toppings)
                Console.WriteLine("    " + topping);
        }

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
