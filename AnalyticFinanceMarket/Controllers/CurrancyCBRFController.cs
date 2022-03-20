using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace AnalyticFinanceMarket.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CurrancyCBRFController : ControllerBase
    {
        public readonly Guid APICode = Guid.Parse("930fe408ce1507a06f64a94ce53ddb53");

        public class Data
        {
            public bool success { get; set; }
            public string terms { get; set; }
            public string privacy { get; set; }
            public long timestamp { get; set; }
            public string source { get; set; }

            
            public Dictionary<string, decimal> quotes { get; set; }
        }

        //        {
        //  "success":true,
        //  "terms":"https:\/\/currencylayer.com\/terms",
        //  "privacy":"https:\/\/currencylayer.com\/privacy",
        //  "timestamp":1647763864,
        //  "source":"USD",
        //  "quotes":{
        //    "USDEUR":0.90395,
        //    "USDGBP":0.758668,
        //    "USDCAD":1.26085,
        //    "USDPLN":4.26697
        //  }
        //}


        [HttpGet]
        [Route("getcurrency")]
        public async Task<IActionResult> GetDataByCurrency()
        {
            string result = "";
            string URL = "http://api.currencylayer.com/live?access_key=930fe408ce1507a06f64a94ce53ddb53&currencies=EUR,GBP,CAD,PLN&source=USD&format=1";
            var client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = await client.GetAsync(client.BaseAddress);
            if (responseMessage.IsSuccessStatusCode)
            {
                result = responseMessage.Content.ReadAsStringAsync().Result;
                var resultObj = JsonConvert.DeserializeObject<Data>(result);
            }
            
            client.Dispose();
            return Content("OK");
        }
    }
}
