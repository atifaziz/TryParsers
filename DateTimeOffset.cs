namespace TryParsers
{
    using System;
    using System.Globalization;

    partial class TryParse
    {
        public static DateTimeOffset? DateTimeOffset(string input)
        {
            DateTimeOffset result;
            return System.DateTimeOffset.TryParse(input, out result) ? result : (DateTimeOffset?) null;
        }

        public static DateTimeOffset? DateTimeOffset(string input, IFormatProvider formatProvider, DateTimeStyles styles)
        {
            DateTimeOffset result;
            return System.DateTimeOffset.TryParse(input, formatProvider, styles, out result) ? result : (DateTimeOffset?) null;
        }

        public static DateTimeOffset? DateTimeOffsetExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles)
        {
            DateTimeOffset result;
            return System.DateTimeOffset.TryParseExact(input, format, formatProvider, styles, out result) ? result : (DateTimeOffset?)null;
        }

        public static DateTimeOffset? DateTimeOffsetExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles)
        {
            DateTimeOffset result;
            return System.DateTimeOffset.TryParseExact(input, formats, formatProvider, styles, out result) ? result : (DateTimeOffset?)null;
        }
    }
}
