using System.Text.Json.Serialization;

namespace ICRYPEX.Net.Models.Public
{
    public class Ticker
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = null!;

        [JsonPropertyName("last")]
        public decimal Last { get; set; }

        [JsonPropertyName("ask")]
        public decimal Ask { get; set; }

        [JsonPropertyName("bid")]
        public decimal Bid { get; set; }

        [JsonPropertyName("high")]
        public decimal High { get; set; }

        [JsonPropertyName("low")]
        public decimal Low { get; set; }

        [JsonPropertyName("avg")]
        public decimal Avg { get; set; }

        [JsonPropertyName("change")]
        public decimal ChangePercentage { get; set; }

        [JsonPropertyName("qty")]
        public decimal Quantity { get; set; }

        [JsonPropertyName("volume")]
        public decimal Volume { get; set; }
    }
}
