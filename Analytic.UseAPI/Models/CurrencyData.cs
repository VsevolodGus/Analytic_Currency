using System.Collections.Generic;
using Newtonsoft.Json;

namespace Analytic.UseAPI.Models
{
    internal class CurrencyData
    {
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }

        [JsonProperty("terms")]
        public string terms { get; set; }

        [JsonProperty("privacy")]
        public string privacy { get; set; }

        [JsonProperty("timestamp")]
        public long TimeStampTicket { get; set; }

        [JsonProperty("source")]
        public string SourceCurrency { get; set; }


        [JsonProperty("quotes")]
        public Dictionary<string, decimal> LevelCurrency { get; set; }
    }
}