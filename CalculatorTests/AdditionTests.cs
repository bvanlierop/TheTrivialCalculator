using CalculatorApp;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    [Category("Unit Tests")]
    public class AdditionTests
    {
        [Test]
        public void Add_OneAndTwo_EqualsThree()
        {
            // Arrange
            int expected = 3;
            var c = new Calculator();
            c.FirstArgument = 1;
            c.SecondArgument = 2;

            // Act
            int actual = c.Add();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
