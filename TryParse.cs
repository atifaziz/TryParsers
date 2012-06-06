#region New BSD License
//
// TryParsers - TryParse from .NET Framework done right
// Copyright (c) 2012, Atif Aziz. All rights reserved.
//
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions are 
// met:
//
// - Redistributions of source code must retain the above copyright notice, 
//   this list of conditions and the following disclaimer.
//
// - Redistributions in binary form must reproduce the above copyright 
//   notice, this list of conditions and the following disclaimer in the 
//   documentation and/or other materials provided with the distribution.
//
// - The names of its contributors may be used to endorse or promote 
//   products derived from this software without specific prior written 
//   permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED 
// TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER 
// OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, 
// EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, 
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
// PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF 
// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS 
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
#endregion

namespace TryParsers
{
    using System;
    using System.Globalization;

    #if TRYPARSERS_LIB
    public partial class TryParse {}
    #endif

    static partial class TryParse
    {
        // Int16

        public static short? Int16(string s)
        {
            short result;
            return short.TryParse(s, out result) ? result : (short?)null;
        }

        public static short? Int16(string s, NumberStyles style, IFormatProvider provider)
        {
            short result;
            return short.TryParse(s, style, provider, out result) ? result : (short?)null;
        }

        // Int32

        public static int? Int32(string s)
        {
            int result;
            return int.TryParse(s, out result) ? result : (int?)null;
        }

        public static int? Int32(string s, NumberStyles style, IFormatProvider provider)
        {
            int result;
            return int.TryParse(s, style, provider, out result) ? result : (int?)null;
        }

        // Int64

        public static long? Int64(string s)
        {
            long result;
            return long.TryParse(s, out result) ? result : (long?)null;
        }

        public static long? Int64(string s, NumberStyles style, IFormatProvider provider)
        {
            long result;
            return long.TryParse(s, style, provider, out result) ? result : (long?)null;
        }

        // Single

        public static float? Single(string s)
        {
            float result;
            return float.TryParse(s, out result) ? result : (float?)null;
        }

        public static float? Single(string s, NumberStyles style, IFormatProvider provider)
        {
            float result;
            return float.TryParse(s, style, provider, out result) ? result : (float?)null;
        }

        // Double

        public static double? Double(string s)
        {
            double result;
            return double.TryParse(s, out result) ? result : (double?)null;
        }

        public static double? Double(string s, NumberStyles style, IFormatProvider provider)
        {
            double result;
            return double.TryParse(s, style, provider, out result) ? result : (double?)null;
        }

        // Decimal

        public static decimal? Decimal(string s)
        {
            decimal result;
            return decimal.TryParse(s, out result) ? result : (decimal?)null;
        }

        public static decimal? Decimal(string s, NumberStyles style, IFormatProvider provider)
        {
            decimal result;
            return decimal.TryParse(s, style, provider, out result) ? result : (decimal?)null;
        }

        // TimeSpan

        public static TimeSpan? TimeSpan(string s)
        {
            TimeSpan result;
            return System.TimeSpan.TryParse(s, out result) ? result : (TimeSpan?)null;
        }

        // DateTime

        public static DateTime? DateTime(string s)
        {
            DateTime result;
            return System.DateTime.TryParse(s, out result) ? result : (DateTime?)null;
        }

        public static DateTime? DateTime(string s, IFormatProvider provider, DateTimeStyles styles)
        {
            DateTime result;
            return System.DateTime.TryParse(s, provider, styles, out result) ? result : (DateTime?)null;
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

        // DateTimeOffset

        public static DateTimeOffset? DateTimeOffset(string input)
        {
            DateTimeOffset result;
            return System.DateTimeOffset.TryParse(input, out result) ? result : (DateTimeOffset?)null;
        }

        public static DateTimeOffset? DateTimeOffset(string input, IFormatProvider formatProvider, DateTimeStyles styles)
        {
            DateTimeOffset result;
            return System.DateTimeOffset.TryParse(input, formatProvider, styles, out result) ? result : (DateTimeOffset?)null;
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
