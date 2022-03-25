namespace Analytic.Domain
{
    public class Currency
    {
        public Guid CurrencyId { get; init; }

        public string CurrencyName { get; init; }

        public string CurrencyShortName { get; init; }

        public Currency(Guid id, string currencyName, string currencyShortName)
        {
            this.CurrencyId = id;
            this.CurrencyName = currencyName;
            this.CurrencyShortName = currencyShortName;
        }
    }
}