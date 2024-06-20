namespace PizzaRestaurant._1_SimpleFactoryPattern.Pizzas
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            this.name = "Cheese Pizza";
            this.dough = "Thick Crust";
            this.sauce = "Tomato Sauce";

            this.toppings.Add("Shredded Mozzarella Cheese");
        }
    }
}
