namespace PizzaRestaurant._2_FactoryMethodPattern.Pizzas
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            this.name = "Chicago Style Deep Dish Veggie Pizza";
            this.dough = "Extra Thick Crust Dough";
            this.sauce = "Plum Tomato Sauce";

            this.toppings.Add("Veggie");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
