using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraArea.Calculators
{
    public class CalculatorAreaBase
    {
        public double result { get; protected set; }
        public virtual void Calculate()
        {
            throw new NotImplementedException();
        }

    }
}
