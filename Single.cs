namespace TryParsers
{
    using System;
    using System.Globalization;

    partial class TryParse
    {
        public static float? Single(string s)
        {
            float result;
            return float.TryParse(s, out result) ? result : (float?) null;
        }
        
        public static float? Single(string s, NumberStyles style, IFormatProvider provider)
        {
            float result;
            return float.TryParse(s, style, provider, out result) ? result : (float?) null;
        }
    }
}
