namespace SnowStorm.Extensions
{
    public static class Strings
    {
        public static bool HasValue(this string input)
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