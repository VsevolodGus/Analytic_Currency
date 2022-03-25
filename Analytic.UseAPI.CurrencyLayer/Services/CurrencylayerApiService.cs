using Analytic.UseAPI.CurrencyLayer.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
namespace Analytic.UseAPI.CurrencyLayer;

internal class CurrencylayerApiService
{
    private const short generalCountAttemt = 5;
    

    public async Task<CurrencyQuotesDTO> GetDataByCurrency(IEnumerable<string> currencies, string sourceCurrecny)
    {
        string curs = string.Join(',', currencies);
        string URL = $"http://api.currencylayer.com/live?access_key=930fe408ce1507a06f64a94ce53ddb53&currencies={curs}&source={sourceCurrecny}&format=1";
        
        var client = new HttpClient()
        {
            BaseAddress = new Uri(URL), 
        };
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        CurrencyQuotesDTO resultObj = null;
        int countAttempt = 0;
        bool isSuccessStatusCode = false;

        do
        {
            var responseMessage = await client.GetAsync(client.BaseAddress);
            if (responseMessage.IsSuccessStatusCode)
            {
                continue;
            }

            var stringJson = await responseMessage.Content.ReadAsStringAsync();
            resultObj = JsonConvert.DeserializeObject<CurrencyQuotesDTO>(stringJson);

            countAttempt++;
            if (responseMessage.IsSuccessStatusCode)
            {
                isSuccessStatusCode = true;
            }

        } while (!isSuccessStatusCode && countAttempt < generalCountAttemt);

        client.Dispose();

        return resultObj;
    }
}
