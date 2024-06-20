namespace PizzaRestaurant._1_SimpleFactoryPattern.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            this.name = "Pepperoni Pizza";
            this.dough = "Thick Crust";
            this.sauce = "Tomato Sauce";

            this.toppings.Add("Shredded Mozzarella Cheese");
        }
    }
}
