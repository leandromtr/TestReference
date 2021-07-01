using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraArea.Calculators
{
    public class CalculatorTriangleArea : CalculatorAreaBase
    {
        public CalculatorTriangleArea(double triangleBase, double height)
        {

        }

        public double Base { get; private set; }
        public double Height { get; private set; }

        public override void Calculate()
        {
            if (Base < 0)
                throw new ArgumentException("Valor do Base não pode ser menor que zero");
            if (Height < 0)
                throw new ArgumentException("Valor do Altura não pode ser menor que zero");

            result = ((Base * Height) / 2);
        }


    }
}
