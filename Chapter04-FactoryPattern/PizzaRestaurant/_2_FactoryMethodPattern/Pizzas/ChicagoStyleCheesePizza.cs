namespace PizzaRestaurant._2_FactoryMethodPattern.Pizzas
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            this.name = "Chicago Style Deep Dish Cheese Pizza";
            this.dough = "Extra Thick Crust Dough";
            this.sauce = "Plum Tomato Sauce";

            this.toppings.Add("Plum Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
