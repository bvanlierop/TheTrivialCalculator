using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public int FirstArgument { get; set; }
        public int SecondArgument { get; set; }

        public int Add()
        {
            return FirstArgument + SecondArgument;
        }
    }
}
