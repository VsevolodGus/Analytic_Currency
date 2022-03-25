using Newtonsoft.Json;

namespace Analytic.UseAPI.CurrencyLayer.Models;

internal class CurrencyQuotesDTO
{
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }

        [JsonProperty("terms")]
        public string? Terms { get; set; }

        [JsonProperty("privacy")]
        public string? Privacy { get; set; }

        [JsonProperty("timestamp")]
        public long TimeStampTikets { get; set; }

        [JsonProperty("source")]
        public string? SourceCurrency { get; set; }

        [JsonProperty("quotes")]
        public Dictionary<string, decimal>? LevelCurrency { get; set; }
}
