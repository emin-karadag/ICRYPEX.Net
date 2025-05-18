namespace ICRYPEX.Net.Core.Helpers
{
    internal static class UnixTimeHelper
    {
        internal static DateTime FromUnixTimestamp(long unixTimestamp)
        {
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return dateTime.AddSeconds(unixTimestamp);
        }

        internal static long ToUnixTimestamp(DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var utcDate = date.ToUniversalTime();
            return (long)(utcDate - epoch).TotalSeconds;
        }

        internal static (long FromUnix, long ToUnix) ToUnixRange(DateTime from, DateTime to)
        {
            long fromUnix = ToUnixTimestamp(from);
            long toUnix = ToUnixTimestamp(to);
            return (fromUnix, toUnix);
        }
    }
}
