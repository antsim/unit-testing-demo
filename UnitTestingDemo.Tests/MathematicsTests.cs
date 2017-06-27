using Xunit;

namespace UnitTestingDemo.Tests
{
    public class MathematicsTests
    {
        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(1, 5, 5)]
        [InlineData(3, 2, 6)]
        [InlineData(2, 0, 0)]
        public void TestMultiplyReturnsCorrectValue(int x, int y, int expected)
        {
            var math = new Mathematics();
            Assert.Equal(expected, math.Multiply(x, y));
        }

        [Theory]
        [InlineData(5, 2, 2)]
        [InlineData(5, 1, 5)]
        [InlineData(10, 2, 5)]
        [InlineData(2, 0, 0)]
        public void TestDivideReturnsCorrectValue(int x, int y, int expected)
        {
            var math = new Mathematics();
            Assert.Equal(expected, math.Divide(x, y));
        }
    }
}