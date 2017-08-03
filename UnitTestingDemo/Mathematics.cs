using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UnitTestingDemo.Core;

namespace UnitTestingDemo
{
    public class Mathematics
    {
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public async Task<decimal> Divide(decimal x, decimal y)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var request = new DivisionRequest()
                {
                    X = x,
                    Y = y
                };

                var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://localhost:58858/api/math/divide", content);
                var contents = response.Content.ReadAsStringAsync();

                return decimal.Parse(contents.Result, CultureInfo.InvariantCulture);
            }
        }
    }
}