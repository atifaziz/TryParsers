namespace TryParsers
{
    using System;
    using System.Globalization;

    partial class TryParse
    {
        public static int? Int32(string s)
        {
            int result;
            return int.TryParse(s, out result) ? result : (int?) null;
        }
        
        public static int? Int32(string s, NumberStyles style, IFormatProvider provider)
        {
            int result;
            return int.TryParse(s, style, provider, out result) ? result : (int?) null;
        }
    }
}
