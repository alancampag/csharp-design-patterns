namespace DecoratorPattern
{
    class TomatoDecorator : IngredientDecorator
    {
        private double cost = 1.00;

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
