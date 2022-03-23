using System;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using Analytic.UseAPI.Models;
using Analytic.DataBase.Models;

namespace Analytic.UseAPI
{
    internal class MapService
    {
        private Mapper _mapper;

        public MapService(IConfigurationProvider configurationProvider)
        {
            _mapper = new Mapper(configurationProvider);
        }

        public List<string> GetListCurrency(CurrencyData model)
        {
            return model.LevelCurrency.Keys.ToList();
        }

        public CurrencyDataDto GetCurencyLevel(CurrencyData model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CurrencyData, CurrencyDataDto>());
                                                           //.ForMember(DateTime, c=> c.DateTime = DateTime.UtcNow+ new TimeSpan(;
            var mapper = new Mapper(config);
            var result = mapper.Map<CurrencyDataDto>(model);
            return result; 
        }
    }
}
