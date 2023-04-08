namespace SnowStorm.Extensions
{
    public static class Strings
    {
        public static bool HasValue(this string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            if (input.Trim().Length == 0)
                return false;

            return true;
        }

        public static bool IsNumeric(this string input)
        {
            return decimal.TryParse(input, out _);
        }

        public static int? ToInt(this string input)
        {
            if (int.TryParse(input, out int value))
                return value;

            return null;
        }

        public static long? ToLong(this string input)
        {
            if (long.TryParse(input, out long value))
                return value;

            return null;
        }

        public static decimal? ToDecimal(this string input)
        {
            if (decimal.TryParse(input, out decimal value))
                return value;

            return null;
        }

        public static bool IsDateTime(this string input)
        {
            return DateTime.TryParse(input, out _);
        }

        public static DateTime? ToDateTime(this string input)
        {
            if (DateTime.TryParse(input, out DateTime value))
                return value;

            return null;
        }


    }
}