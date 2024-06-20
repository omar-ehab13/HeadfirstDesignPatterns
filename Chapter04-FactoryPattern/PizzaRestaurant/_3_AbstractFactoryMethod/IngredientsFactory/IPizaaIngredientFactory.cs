using PizzaRestaurant._3_AbstractFactoryMethod.Ingredients;

namespace PizzaRestaurant._3_AbstractFactoryMethod.IngredientsFactory
{
    public interface IPizaaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public List<Veggie> CreateVeggies();
    }
}
