namespace PizzaRestaurant._2_FactoryMethodPattern.Pizzas
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            this.name = "NY Style Sauce and Veggie Pizza";
            this.dough = "Thin Crust Dough";
            this.sauce = "Marinara Sauce";

            this.toppings.Add("Veggie");
        }
    }
}
