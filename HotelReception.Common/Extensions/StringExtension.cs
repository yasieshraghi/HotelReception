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
        public static byte ToByte(this string value)
        {
            return byte.TryParse(value, NumberStyles.Any,
                NumberFormatInfo.CurrentInfo, out var result) ? result : (byte)0;
        }

        public static string GetTitle(this bool item) => item ? "Yas" : "No";

    }
}