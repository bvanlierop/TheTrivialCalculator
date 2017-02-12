using CalculatorApp;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CalculatorAcceptanceTests
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator _calculator = new Calculator();
        private int _result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int firstArgument)
        {
            _calculator.FirstArgument = firstArgument;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int secondArgument)
        {
            _calculator.SecondArgument = secondArgument;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expected)
        {
            int actual = _result;
            Assert.AreEqual(expected, actual);
        }
    }
}
