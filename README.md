# ICRYPEX.Net

ICRYPEX borsası için geliştirilmiş .NET kütüphanesidir. Bu kütüphane, ICRYPEX borsasının API'sine kolay erişim sağlar ve kripto para işlemlerini programatik olarak gerçekleştirmenize olanak tanır.

## Installation

```bash
dotnet add package ICRYPEX.Net
```

## Features

- ICRYPEX borsası API entegrasyonu
- Kripto para alım-satım işlemleri
- Piyasa verilerine erişim
- Hesap yönetimi

## Usage

### Client Oluşturma

```csharp
using ICRYPEX.Net.Services;

// Client oluşturma
var client = new IcrypexClient();
```

### Public API Metodları

#### 1. Exchange Bilgilerini Alma

```csharp
// Tüm borsa bilgilerini alma
var exchangeInfo = await client.PublicApi.GetExchangeInfoAsync();

// Örnek kullanım
Console.WriteLine($"Borsa Versiyonu: {exchangeInfo.Version}");
foreach (var asset in exchangeInfo.Assets)
{
    Console.WriteLine($"Varlık: {asset.Symbol}, İsim: {asset.Name}");
}
```

#### 2. Tüm Sembollerin Fiyat Bilgilerini Alma

```csharp
// Tüm sembollerin anlık fiyat bilgilerini alma
var tickers = await client.PublicApi.GetTickersAsync();

// Örnek kullanım
foreach (var ticker in tickers)
{
    Console.WriteLine($"Sembol: {ticker.Symbol}");
    Console.WriteLine($"Son Fiyat: {ticker.Last}");
    Console.WriteLine($"24s Değişim: %{ticker.ChangePercentage}");
    Console.WriteLine($"24s Hacim: {ticker.Volume}");
}
```

#### 3. Emir Defteri Bilgilerini Alma

```csharp
// Belirli bir sembol için emir defteri bilgilerini alma
var orderBook = await client.PublicApi.GetOrderBookAsync("BTCUSDT");

// Örnek kullanım
Console.WriteLine($"Sembol: {orderBook.PairSymbol}");
Console.WriteLine("Alış Emirleri:");
foreach (var bid in orderBook.Bids)
{
    Console.WriteLine($"Fiyat: {bid.Price}, Miktar: {bid.Quantity}");
}
```

#### 4. Son İşlemleri Alma

```csharp
// Belirli bir sembol için son işlemleri alma
var lastTrades = await client.PublicApi.GetLastTradesAsync("BTCUSDT");

// Örnek kullanım
foreach (var trade in lastTrades.Trades)
{
    Console.WriteLine($"Tarih: {DateTimeOffset.FromUnixTimeSeconds(trade.Timestamp)}");
    Console.WriteLine($"Fiyat: {trade.Price}");
    Console.WriteLine($"Miktar: {trade.Quantity}");
    Console.WriteLine($"Yön: {trade.Side}");
}
```

#### 5. Mum (K-Line) Verilerini Alma

```csharp
using ICRYPEX.Net.Core.Enums;

// Belirli bir sembol için mum verilerini alma
var fromDate = DateTime.UtcNow.AddDays(-30);
var toDate = DateTime.UtcNow;
var klineData = await client.PublicApi.GetKlineDataAsync(
    "BTCUSDT",
    fromDate,
    toDate,
    KLineResolutionEnum.OneDay
);

// Örnek kullanım
foreach (var candle in klineData)
{
    Console.WriteLine($"Tarih: {candle.Timestamp}");
    Console.WriteLine($"Açılış: {candle.Open}");
    Console.WriteLine($"Yüksek: {candle.High}");
    Console.WriteLine($"Düşük: {candle.Low}");
    Console.WriteLine($"Kapanış: {candle.Close}");
    Console.WriteLine($"Hacim: {candle.Volume}");
}
```

### K-Line Çözünürlük Seçenekleri

```csharp
public enum KLineResolutionEnum
{
    OneMinute = 1,      // 1 dakika
    FiveMinutes = 5,    // 5 dakika
    FifteenMinutes = 15,// 15 dakika
    OneHour = 60,       // 1 saat
    FourHours = 240,    // 4 saat
    OneDay = 1440,      // 1 gün
    ThreeDays = 4320,   // 3 gün
    OneWeek = 10080,    // 1 hafta
    OneMonth = 43200    // 1 ay (30 gün)
}
```

## Error Handling

```csharp
try
{
    var client = new IcrypexClient();
    var result = await client.PublicApi.GetTickersAsync();
}
catch (Exception ex)
{
    Console.WriteLine($"Hata oluştu: {ex.Message}");
}
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
