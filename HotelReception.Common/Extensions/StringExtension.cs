using System.Globalization;

namespace HotelReception.Common.Extensions
{
    public static class StringExtension
    {
        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);

        public static bool IsNumeric(this string value)
        {
            return decimal.TryParse(value, NumberStyles.Any,
                NumberFormatInfo.CurrentInfo, out _);

        }

        public static int ToInt(this string value)
        {
            return int.TryParse(value, NumberStyles.Any,
                NumberFormatInfo.CurrentInfo, out var result) ? result : 0;
        }

        public static long ToLong(this string value)
        {
            return long.TryParse(value, NumberStyles.Any,
                NumberFormatInfo.CurrentInfo, out var result) ? result : 0;
        }
    }
}