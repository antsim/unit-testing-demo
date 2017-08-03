using System.Threading.Tasks;
using UnitTestingDemo.Core;
using UnitTestingDemo.Services;

namespace UnitTestingDemo
{
    public class Mathematics
    {
        private readonly IMathService mathService;
        public Mathematics(IMathService mathService)
        {
            // Currently this will always be null if this application would be actually run
            // to inject dependencies runtime, you can use DI libraries like Ninject (basic) or Autofac (advanced)
            // you would basically just say 
            // Bind<IMathService>.To<MathService>();
            this.mathService = mathService;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public async Task<decimal> Divide(decimal x, decimal y)
        {
            return await mathService.Divide(new DivisionRequest {X = x, Y = y});
        }
    }
}