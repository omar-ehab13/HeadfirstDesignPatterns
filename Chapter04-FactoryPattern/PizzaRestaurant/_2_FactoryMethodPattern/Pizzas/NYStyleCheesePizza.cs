namespace PizzaRestaurant._2_FactoryMethodPattern.Pizzas
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            this.name = "NY Style Sauce and Cheese Pizza";
            this.dough = "Thin Crust Dough";
            this.sauce = "Marinara Sauce";

            this.toppings.Add("Crated Reggiano Cheese");
        }
    }
}
