using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraArea.Calculators
{
    public class CalculatorRectangleArea : CalculatorAreaBase
    {
        public CalculatorRectangleArea(double baseRectangle, double height)
        {
            Base = baseRectangle;
            Height = height;
        }


        public double Base { get; private set; }
        public double Height { get; private set; }
        public override void Calculate()
        {
            if (Base < 0)
                throw new ArgumentException("Base value cannot be less than zero");
            if (Height < 0)
                throw new ArgumentException("Height value cannot be less than zero");

            result = Base * Height;
        }
    }
}
