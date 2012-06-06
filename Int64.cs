namespace TryParsers
{
    using System;
    using System.Globalization;

    partial class TryParse
    {
        public static long? Int64(string s)
        {
            long result;
            return long.TryParse(s, out result) ? result : (long?) null;
        }
        
        public static long? Int64(string s, NumberStyles style, IFormatProvider provider)
        {
            long result;
            return long.TryParse(s, style, provider, out result) ? result : (long?) null;
        }
    }
}
