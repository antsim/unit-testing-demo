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
    }
}