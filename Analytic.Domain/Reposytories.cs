using Analytic.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analytic.Domain
{
    public class RepositoryCurrency
    {
        private readonly List<CurrencyDto> _currencies;

        public List<CurrencyDataDto> _currencyDatas;

        public RepositoryCurrency()
        {
            this._currencies = new List<CurrencyDto>();
            this._currencyDatas = new List<CurrencyDataDto>();
        }


        public void AddCurrency(CurrencyDto model)
        {
            _currencies.Add(model);
        }
    }
}
