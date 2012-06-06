namespace TryParsers
{
    using System;
    using System.Globalization;

    partial class TryParse
    {
        public static double? Double(string s)
        {
            double result;
            return double.TryParse(s, out result) ? result : (double?) null;
        }
        
        public static double? Double(string s, NumberStyles style, IFormatProvider provider)
        {
            double result;
            return double.TryParse(s, style, provider, out result) ? result : (double?) null;
        }
    }
}
