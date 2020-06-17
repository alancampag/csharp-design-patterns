using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ChickenDecorator : IngredientDecorator
    {
        private readonly Pizza pizza;
        private readonly double cost = 4.00;

        public ChickenDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override double Cost()
        {
            return this.pizza.Cost() + this.cost;
        }
    }
}
