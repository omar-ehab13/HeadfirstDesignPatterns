namespace PizzaRestaurant._1_SimpleFactoryPattern.Pizzas
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            this.name = "Veggie Pizza";
            this.dough = "Thick Crust";
            this.sauce = "Tomato Sauce";

            this.toppings.Add("Shredded Mozzarella Cheese");
        }
    }
}
