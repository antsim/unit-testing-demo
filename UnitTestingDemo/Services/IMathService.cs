using System.Threading.Tasks;
using UnitTestingDemo.Core;

namespace UnitTestingDemo.Services
{
    public interface IMathService
    {
        Task<decimal> Divide(DivisionRequest request);
    }
}