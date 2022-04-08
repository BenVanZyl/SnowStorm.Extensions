using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowStorm.Extensions
{
    public static class DatesAndTime
    {
        public static string ToStringSortableDateTime(this DateTime input)
        {
            return input.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string ToStringSortableDate(this DateTime input)
        {
            return input.ToString("yyyy-MM-dd");
        }
    }
}
