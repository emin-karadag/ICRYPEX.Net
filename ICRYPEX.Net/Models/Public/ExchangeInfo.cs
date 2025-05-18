using System.Text.Json.Serialization;

namespace ICRYPEX.Net.Models.Public
{
    public class ExchangeInfo
    {
        [JsonPropertyName("version")]
        public string Version { get; set; } = null!;

        [JsonPropertyName("assets")]
        public List<Asset>? Assets { get; set; }

        [JsonPropertyName("pairs")]
        public List<Pair>? Pairs { get; set; }

        public class Asset
        {
            [JsonPropertyName("symbol")]
            public string Symbol { get; set; } = null!;

            [JsonPropertyName("name")]
            public string Name { get; set; } = null!;

            [JsonPropertyName("categories")]
            public List<string>? Categories { get; set; }

            [JsonPropertyName("description")]
            public string? Description { get; set; }

            [JsonPropertyName("type")]
            public string Type { get; set; } = null!;

            [JsonPropertyName("isEnabled")]
            public bool IsEnabled { get; set; }

            [JsonPropertyName("isNew")]
            public bool IsNew { get; set; }

            [JsonPropertyName("isWithdrawalEnabled")]
            public bool IsWithdrawalEnabled { get; set; }

            [JsonPropertyName("isDepositEnabled")]
            public bool IsDepositEnabled { get; set; }

            [JsonPropertyName("precision")]
            public int Precision { get; set; }

            [JsonPropertyName("displayPrecision")]
            public int DisplayPrecision { get; set; }

            [JsonPropertyName("minDeposit")]
            public decimal MinDeposit { get; set; }

            [JsonPropertyName("minWithdrawal")]
            public decimal MinWithdrawal { get; set; }

            [JsonPropertyName("updatedDate")]
            public long? UpdatedDate { get; set; }

            [JsonPropertyName("createdDate")]
            public long CreatedDate { get; set; }
        }

        public class Pair
        {
            [JsonPropertyName("symbol")]
            public string Symbol { get; set; } = null!;

            [JsonPropertyName("base")]
            public string Base { get; set; } = null!;

            [JsonPropertyName("quote")]
            public string Quote { get; set; } = null!;

            [JsonPropertyName("minExchangeValue")]
            public decimal MinExchangeValue { get; set; }

            [JsonPropertyName("minPrice")]
            public decimal MinPrice { get; set; }

            [JsonPropertyName("maxPrice")]
            public decimal MaxPrice { get; set; }

            [JsonPropertyName("quantityPrecision")]
            public int QuantityPrecision { get; set; }

            [JsonPropertyName("pricePrecision")]
            public int PricePrecision { get; set; }

            [JsonPropertyName("totalPrecision")]
            public int TotalPrecision { get; set; }

            [JsonPropertyName("commissionPrecision")]
            public int CommissionPrecision { get; set; }

            [JsonPropertyName("displayOrder")]
            public int DisplayOrder { get; set; }

            [JsonPropertyName("status")]
            public string Status { get; set; } = null!;

            [JsonPropertyName("marketTypes")]
            public List<string> MarketTypes { get; set; } = null!;

            [JsonPropertyName("orderTypes")]
            public List<string> OrderTypes { get; set; } = null!;

            [JsonPropertyName("tickSize")]
            public decimal TickSize { get; set; }

            [JsonPropertyName("priceLimitFactor")]
            public decimal PriceLimitFactor { get; set; }
        }
    }
}
