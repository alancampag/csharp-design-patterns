using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class TomatoDecorator : IngredientDecorator
    {
        private readonly Pizza pizza;
        private readonly double cost = 1.00;

        public TomatoDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override double Cost()
        {
            return this.pizza.Cost() + this.cost;
        }
    }
}
