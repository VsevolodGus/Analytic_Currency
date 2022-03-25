using AutoMapper;

namespace Analytic.UseAPI.CurrencyLayer;

public class UseApiCurrencyLayerManager
{
    private readonly CurrencylayerApiService _currencylayerApiService;
    private readonly MappingModels _mappingModels;
    public UseApiCurrencyLayerManager(IMapper mapper)
    {
        _currencylayerApiService = new CurrencylayerApiService();
        _mappingModels = new MappingModels(mapper);
    }

    public async Task GetCurrencyQuotes(IEnumerable<string> currency, string sourceCurrency)
    {
        var dataFromAPI = await _currencylayerApiService.GetDataByCurrency(currency, sourceCurrency);


        _mappingModels.MapDataCurrencyQuotes(dataFromAPI);
        // TODO: 
        // map model

    }


}
