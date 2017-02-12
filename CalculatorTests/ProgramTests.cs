using System;
using System.IO;
using System.Text;
using ConsoleUI;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    [Category("Unit Tests")]
    public class ProgramTests
    {
        [Test]
        public void Main_TwoNumbers_CallsConsoleWithTheirSum()
        {
            //Given (Arrange)
            var input = new string[] { "1", "2" };

            var fakeOutput = new StringBuilder();
            using (var sw = new StringWriter(fakeOutput))
            {
                Console.SetOut(sw);

                //Simulate user input
                using (var sr = new StringReader(string.Format("{1}{0}{2}{0}", Environment.NewLine,
                    input[0], input[1])))
                {
                    Console.SetIn(sr);

                    //When (Act)
                    Program.Main(null);
                }
            }

            //Then (Assert)
            string actual = fakeOutput.ToString();
            StringAssert.Contains("sum", actual);
            StringAssert.Contains("3", actual);

            //Links
            //http://www.mfranc.com/unit-testing/unit-test-code-with-static-method-console-write/
            //https://www.youtube.com/watch?v=yyPsRZuRb8E (roy osherove)
            //https://blogs.msdn.microsoft.com/ploeh/2006/10/21/console-unit-testing/
        }
    }
}
