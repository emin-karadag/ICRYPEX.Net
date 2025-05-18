namespace ICRYPEX.Net.Core.Enums
{
    public enum KLineResolutionEnum
    {
        OneMinute = 1,
        FiveMinutes = 5,
        FifteenMinutes = 15,
        OneHour = 60,
        FourHours = 240,
        OneDay = 1440, // "1D" kullanımı için
        ThreeDays = 4320, // "3D" kullanımı için
        OneWeek = 10080, // "1W" kullanımı için
        OneMonth = 43200 // "1M" kullanımı için (30 gün)
    }
}
