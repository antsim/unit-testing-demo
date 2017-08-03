using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnitTestingDemo.Core;

namespace UnitTestingDemo.Services
{
    public class MathService : IMathService
    {
        public async Task<decimal> Divide(DivisionRequest request)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://localhost:58858/api/math/divide", content);
                var contents = response.Content.ReadAsStringAsync();

                return decimal.Parse(contents.Result, CultureInfo.InvariantCulture);
            }
        }
    }
}