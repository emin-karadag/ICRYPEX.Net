using System.Text.Json.Serialization;

namespace ICRYPEX.Net.Models.Public
{
    public class OrderBook
    {
        [JsonPropertyName("pairSymbol")]
        public string? PairSymbol { get; set; }

        [JsonPropertyName("asks")]
        public List<OrderBookEntry>? Asks { get; set; }

        [JsonPropertyName("bids")]
        public List<OrderBookEntry>? Bids { get; set; }

        public class OrderBookEntry
        {
            [JsonPropertyName("p")] // Price
            public decimal Price { get; set; }

            [JsonPropertyName("q")] // Quantity
            public decimal Quantity { get; set; }
        }
    }
}
