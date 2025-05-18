using System.Text.Json.Serialization;

namespace ICRYPEX.Net.Models.Public
{
    public class LastTrade
    {
        [JsonPropertyName("trades")]
        public List<Trade> Trades { get; set; } = new List<Trade>();

        public class Trade
        {
            [JsonPropertyName("d")] // Date in unix seconds
            public long Timestamp { get; set; }

            [JsonPropertyName("p")] //Price 
            public decimal Price { get; set; }

            [JsonPropertyName("q")] // Quantity 
            public decimal Quantity { get; set; }

            [JsonPropertyName("s")]
            public string? Side { get; set; } // "BUY" or "SELL"
        }
    }
}
