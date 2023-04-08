
namespace SnowStorm.Extensions
{
    public static class DatesAndTime
    {
        public static string ToStringSortableDateTime(this DateTime input, bool includeSeconds = false)
        {
            string seconds = "";
            if (includeSeconds) seconds = ":ss";
            return input.ToString($"yyyy-MM-dd HH:mm{seconds}");
        }

        public static string ToStringSortableDateTime(this DateTime? input, bool includeSeconds = false)
        {
            if (!input.HasValue)
                return "";

            string seconds = "";
            if (includeSeconds) seconds = ":ss";
            return input.Value.ToString($"yyyy-MM-dd HH:mm{seconds}");
        }

        public static string ToStringSortableDate(this DateTime input)
        {
            return input.ToString("yyyy-MM-dd");
        }

        public static string ToStringSortableDate(this DateTime? input)
        {
            if (!input.HasValue)
                return "";

            return input.Value.ToString("yyyy-MM-dd");
        }

    }
}
