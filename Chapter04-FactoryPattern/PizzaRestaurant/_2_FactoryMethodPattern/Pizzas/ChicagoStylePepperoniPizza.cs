namespace PizzaRestaurant._2_FactoryMethodPattern.Pizzas
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            this.name = "Chicago Style Deep Dish Pepperoni Pizza";
            this.dough = "Extra Thick Crust Dough";
            this.sauce = "Plum Tomato Sauce";

            this.toppings.Add("Pepperoni");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
