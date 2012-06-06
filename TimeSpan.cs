namespace TryParsers
{
    using System;

    partial class TryParse
    {
        public static TimeSpan? TimeSpan(string s)
        {
            TimeSpan result;
            return System.TimeSpan.TryParse(s, out result) ? result : (TimeSpan?) null;
        }
    }
}
