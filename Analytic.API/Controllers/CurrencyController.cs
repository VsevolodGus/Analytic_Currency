using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Analytic.API.Controllers
{
    public class CurrencyController : Controller
    {
        public class Data
        {
            public bool success { get; set; }
            public string terms { get; set; }
            public string privacy { get; set; }
            public long timestamp { get; set; }
            public string source { get; set; }
            public Dictionary<string, decimal> quotes { get; set; }
        }

        [HttpGet]
        [Route("getcurrency")]
        public async Task<IActionResult> GetDataByCurrency()
        {
            string stringJson = "";
            string URL = "http://api.currencylayer.com/live?access_key=930fe408ce1507a06f64a94ce53ddb53&currencies=EUR,GBP,CAD,PLN&source=USD&format=1";
            var client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = await client.GetAsync(client.BaseAddress);
            if (responseMessage.IsSuccessStatusCode)
            {
                stringJson = responseMessage.Content.ReadAsStringAsync().Result;
                var resultObj = JsonConvert.DeserializeObject<Data>(stringJson);
                DateTime date = DateTime.UtcNow;
                TimeSpan asd = new TimeSpan(resultObj.timestamp);
                DateTime dateTime = date.AddTicks(asd.Ticks);
            }

            client.Dispose();
            return Content("OK");
        }
    }
}
