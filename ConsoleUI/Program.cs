using System;
using CalculatorApp;

namespace ConsoleUI
{
    // Making Program public for testability.
    // Or use compiler flag TEST or make internal 
    //  with InternalVisibleTo attribute in AssemblyInfo.cs
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("CalculatorApp - Addition");

            Console.WriteLine("Please enter the first number: ");
            string line = Console.ReadLine();
            int a = int.Parse(line);

            Console.WriteLine("Please enter the second number: ");
            line = Console.ReadLine();
            int b = int.Parse(line);

            // Do the calculation
            var calculator = new Calculator();
            calculator.FirstArgument = a;
            calculator.SecondArgument = b;
            var sum = calculator.Add();

            Console.WriteLine(string.Format(
                "The sum of '{0}' and '{1}' is '{2}'.{3}",
                a, b, sum, Environment.NewLine));
 
            //Untestable, will need mock for this
            //Console.ReadKey(true);
        }
    }
}
