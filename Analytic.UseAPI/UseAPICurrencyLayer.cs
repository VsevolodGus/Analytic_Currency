using Analytic.UseAPI.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Analytic.UseAPI
{
    public class UseAPICurrencyLayer
    {
        private const short _CountAttempt = 5;
        internal static async Task<CurrencyData> GetDataCurrency()
        {
            bool IsSuccess = false;
            short countAttempt = 0;
            var client = new HttpClient();

            do
            {
                string stringJson = "";
                string URL = "http://api.currencylayer.com/live?access_key=930fe408ce1507a06f64a94ce53ddb53&currencies=EUR,GBP,CAD,PLN&source=USD&format=1";
                client.BaseAddress = new Uri(URL);

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var responseMessage = await client.GetAsync(client.BaseAddress);
                CurrencyData resultObj;
                if (responseMessage.IsSuccessStatusCode)
                {
                    stringJson = responseMessage.Content.ReadAsStringAsync().Result;
                    resultObj = JsonConvert.DeserializeObject<CurrencyData>(stringJson);
                    return resultObj;
                }

            } while (!IsSuccess && countAttempt <= _CountAttempt);

            client.Dispose();
            return null;
        }
    }
}
