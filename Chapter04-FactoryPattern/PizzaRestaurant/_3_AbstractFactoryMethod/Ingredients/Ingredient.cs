namespace PizzaRestaurant._3_AbstractFactoryMethod.Ingredients
{
    public abstract class Ingredient
    {
        protected string _name = null!;

        public string GetName()
        {
            return this._name;
        }
    }
}
