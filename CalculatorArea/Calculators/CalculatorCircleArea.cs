using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraArea.Calculators
{
    public class CalculatorCircleArea : CalculatorAreaBase
    {
        public CalculatorCircleArea(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; private set; }

        public override void Calculate()
        {
            if (Radius < 0)
                throw new ArgumentException("Radius value cannot be less than zero");
            result = Math.PI * (Math.Pow(Radius, 2));
        }
    }
}
