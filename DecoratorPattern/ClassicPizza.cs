using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ClassicPizza : Pizza
    {
        public override double Cost()
        {
            return 5.00;
        }
    }
}
