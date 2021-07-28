using Newtonsoft.Json;

namespace Application.Common.Models
{
    public class BitcoinPriceCurrencyDto
    {
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }

        [JsonProperty("rate_float")]
        public float RateFloat { get; set; }
    }
}