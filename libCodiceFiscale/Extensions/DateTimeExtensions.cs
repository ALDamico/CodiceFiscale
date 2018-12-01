using System;

namespace libCodiceFiscale.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Extension method to return the last two digits of a year as an integer.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int YearToTwoDigits(this DateTime input)
        {
            return Convert.ToInt32(input.Year.ToString().Substring(2, 2));
        }
    }
}