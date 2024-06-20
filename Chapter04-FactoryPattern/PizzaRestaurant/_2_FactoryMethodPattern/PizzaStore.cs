﻿using PizzaRestaurant._2_FactoryMethodPattern.Pizzas;

namespace PizzaRestaurant._2_FactoryMethodPattern
{
    public abstract class PizzaStore
    {
        public Pizza? OrderPizza(string type)
        {
            Pizza? pizza = CreatePizza(type);

            if (pizza == null) return null;

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        // Allowing subclassing to decide which pizza to create.
        protected abstract Pizza? CreatePizza(string type);
    }
}
