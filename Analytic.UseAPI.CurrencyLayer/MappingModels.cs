using Analytic.UseAPI.CurrencyLayer.Models;
using AutoMapper;

namespace Analytic.UseAPI.CurrencyLayer;

internal class MappingModels
{
    private readonly IMapper _mapper;

    public MappingModels(IMapper mapper)
    {
        this._mapper = mapper;
    }

    public void MapDataCurrencyQuotes(CurrencyQuotesDTO model)
    {
        //var result = _mapper.Map(model);
        var asd = _mapper.ConfigurationProvider;
    }
}
