namespace TryParsers
{
    using System;
    using System.Globalization;

    partial class TryParse
    {
        public static short? Int16(string s)
        {
            short result;
            return short.TryParse(s, out result) ? result : (short?) null;
        }
        
        public static short? Int16(string s, NumberStyles style, IFormatProvider provider)
        {
            short result;
            return short.TryParse(s, style, provider, out result) ? result : (short?) null;
        }
    }
}
