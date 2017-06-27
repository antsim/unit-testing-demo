using Microsoft.AspNetCore.Mvc;
using UnitTestingDemo.Core;

namespace UnitTestingDemo.API.Controllers
{
    [Route("api/[controller]")]
    public class MathController : Controller
    {
        [HttpPost]
        [Route("divide")]
        public decimal Divide([FromBody]DivisionRequest request)
        {
            if (request.X == 0 || request.Y == 0)
            {
                return 0;
            }

            return request.X / request.Y;
        }

        [HttpGet]
        [Route("test")]
        public string Test()
        {
            return "test";
        }
    }
}
