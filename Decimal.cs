namespace TryParsers
{
    using System;
    using System.Globalization;

    partial class TryParse
    {
        public static decimal? Decimal(string s)
        {
            decimal result;
            return decimal.TryParse(s, out result) ? result : (decimal?) null;
        }
        
        public static decimal? Decimal(string s, NumberStyles style, IFormatProvider provider)
        {
            decimal result;
            return decimal.TryParse(s, style, provider, out result) ? result : (decimal?) null;
        }
    }
}
