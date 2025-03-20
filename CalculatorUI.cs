using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    interface CalculatorUI
    {
        public void DisplayOperations();
        public double? RequestArguement();
        public void ShowError();
        public void ShowResult(double result);
        public int SelectOperationIndex();
    }
}
