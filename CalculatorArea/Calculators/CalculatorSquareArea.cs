using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraArea.Calculators
{
    public class CalculatorSquareArea : CalculatorAreaBase
    {
        public CalculatorSquareArea(double side)
        {
            Side = side;

        }

        public double Side { get; private set; }
        public override void Calculate()
        {
            if (Side < 0)
                throw new ArgumentException("Side value cannot be less than zero");

            result = Math.Pow(Side, 2);
        }
    }
}
