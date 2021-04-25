namespace DecoratorPattern
{
    class ChickenDecorator : IngredientDecorator
    {
        private double cost = 4.00;

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
