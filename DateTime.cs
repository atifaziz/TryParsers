namespace TryParsers
{
    using System;
    using System.Globalization;

    partial class TryParse
    {
        public static DateTime? DateTime(string s)
        {
            DateTime result;
            return System.DateTime.TryParse(s, out result) ? result : (DateTime?) null;
        }

        public static DateTime? DateTime(string s, IFormatProvider provider, DateTimeStyles styles)
        {
            DateTime result;
            return System.DateTime.TryParse(s, provider, styles, out result) ? result : (DateTime?) null;
        }

        public static DateTime? DateTimeExact(string s, string format, IFormatProvider provider, DateTimeStyles styles)
        {
            DateTime result;
            return System.DateTime.TryParseExact(s, format, provider, styles, out result) ? result : (DateTime?)null;
        }

        public static DateTime? DateTimeExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles)
        {
            DateTime result;
            return System.DateTime.TryParseExact(s, formats, provider, styles, out result) ? result : (DateTime?)null;
        }
    }
}
