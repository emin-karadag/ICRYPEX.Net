using System.Text.Json.Serialization;

namespace ICRYPEX.Net.Models.Public
{
    public class KLine
    {
        [JsonPropertyName("s")]
        public string Status { get; set; } = null!;

        [JsonPropertyName("t")]
        public long[] Timestamps { get; set; } = []; // Unix timestamps (saniye)

        [JsonPropertyName("h")]
        public decimal[] HighPrices { get; set; } = [];

        [JsonPropertyName("o")]
        public decimal[] OpenPrices { get; set; } = [];

        [JsonPropertyName("l")]
        public decimal[] LowPrices { get; set; } = [];

        [JsonPropertyName("c")]
        public decimal[] ClosePrices { get; set; } = [];

        [JsonPropertyName("v")]
        public decimal[] Volumes { get; set; } = [];

        public class KLineData
        {
            public DateTime Timestamp { get; set; }
            public decimal Open { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Close { get; set; }
            public decimal Volume { get; set; }
        }
    }
}
