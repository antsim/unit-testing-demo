using System.Threading.Tasks;
using Moq;
using UnitTestingDemo.Core;
using UnitTestingDemo.Services;
using Xunit;

namespace UnitTestingDemo.Tests
{
    public class MathematicsTests
    {
        private readonly Mock<IMathService> mathServiceMock;

        public MathematicsTests()
        {
            mathServiceMock = new Mock<IMathService>();
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(1, 5, 5)]
        [InlineData(3, 2, 6)]
        [InlineData(2, 0, 0)]
        public void TestMultiplyReturnsCorrectValue(int x, int y, int expected)
        {
            mathServiceMock.Setup(m => m.Divide(It.IsAny<DivisionRequest>())).Returns(Task.FromResult(decimal.Parse(expected.ToString())));

            var math = new Mathematics(mathServiceMock.Object);
            Assert.Equal(expected, math.Multiply(x, y));
        }

        [Theory]
        [InlineData(5, 2, 2.5)]
        [InlineData(5, 1, 5)]
        [InlineData(10, 2, 5)]
        [InlineData(2, 5, 0.4)]
        public void TestDivideReturnsCorrectValue(decimal x, decimal y, decimal expected)
        {
            mathServiceMock.Setup(m => m.Divide(It.IsAny<DivisionRequest>())).Returns(Task.FromResult(expected));

            var math = new Mathematics(mathServiceMock.Object);
            Assert.Equal(expected, math.Divide(x, y).Result);
        }

        [Fact]
        public void TestDivisionByZeroReturnsZero()
        {
            mathServiceMock.Setup(m => m.Divide(It.IsAny<DivisionRequest>())).Returns(Task.FromResult(0m));
            var math = new Mathematics(mathServiceMock.Object);
            Assert.Equal(0, math.Divide(2, 0).Result);
        }
    }
}