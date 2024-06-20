namespace PizzaRestaurant._2_FactoryMethodPattern.Pizzas
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            this.name = "NY Style Sauce and Pepperoni Pizza";
            this.dough = "Thin Crust Dough";
            this.sauce = "Marinara Sauce";

            this.toppings.Add("Pepperoni");
        }
    }
}
