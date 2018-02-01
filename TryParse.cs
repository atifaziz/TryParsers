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
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;

    #if TRYPARSERS_LIB
    public partial class TryParse {}
    #else
    #pragma warning disable 3021  // 'method' does not need a CLSCompliant attribute because the assembly does not have a CLSCompliant attribute
    #endif

    static partial class TryParse
    {
        // Boolean

        public static bool? Boolean(string value)
        {
            bool result;
            return bool.TryParse(value, out result) ? result : (bool?)null;
        }

        // SByte

        [CLSCompliant(false)]
        public static sbyte? SByte(string s)
        {
            sbyte result;
            return sbyte.TryParse(s, out result) ? result : (sbyte?)null;
        }

        [CLSCompliant(false)]
        public static sbyte? SByte(string s, NumberStyles style, IFormatProvider provider)
        {
            sbyte result;
            return sbyte.TryParse(s, style, provider, out result) ? result : (sbyte?)null;
        }

        // Byte

        public static byte? Byte(string s)
        {
            byte result;
            return byte.TryParse(s, out result) ? result : (byte?)null;
        }

        public static byte? Byte(string s, NumberStyles style, IFormatProvider provider)
        {
            byte result;
            return byte.TryParse(s, style, provider, out result) ? result : (byte?)null;
        }

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

        // UInt16

        [CLSCompliant(false)]
        public static ushort? UInt16(string s)
        {
            ushort result;
            return ushort.TryParse(s, out result) ? result : (ushort?)null;
        }

        [CLSCompliant(false)]
        public static ushort? UInt16(string s, NumberStyles style, IFormatProvider provider)
        {
            ushort result;
            return ushort.TryParse(s, style, provider, out result) ? result : (ushort?)null;
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

        // UInt32

        [CLSCompliant(false)]
        public static uint? UInt32(string s)
        {
            uint result;
            return uint.TryParse(s, out result) ? result : (uint?)null;
        }

        [CLSCompliant(false)]
        public static uint? UInt32(string s, NumberStyles style, IFormatProvider provider)
        {
            uint result;
            return uint.TryParse(s, style, provider, out result) ? result : (uint?)null;
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

        // UInt64

        [CLSCompliant(false)]
        public static ulong? UInt64(string s)
        {
            ulong result;
            return ulong.TryParse(s, out result) ? result : (ulong?)null;
        }

        [CLSCompliant(false)]
        public static ulong? UInt64(string s, NumberStyles style, IFormatProvider provider)
        {
            ulong result;
            return ulong.TryParse(s, style, provider, out result) ? result : (ulong?)null;
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

        // Enum

        public static T? Enum<T>(string value) where T : struct
        {
            return Enum<T>(value, false);
        }

        public static T? Enum<T>(string value, bool ignoreCase) where T : struct
        {
            return EnumImpl<T>.TryParse(value, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
        }

        static class StringSeparatorStock
        {
            public static readonly char[] Comma = new[] { ',' };
        }

        static class EnumImpl<T> where T : struct
        {                                                        // ReSharper disable StaticFieldInGenericType
            static KeyValuePair<string, ulong>[] _cachedMembers; // ReSharper restore StaticFieldInGenericType
                                                                 // ReSharper disable ReturnTypeCanBeEnumerable.Local
            static KeyValuePair<string, ulong>[] Members         // ReSharper restore ReturnTypeCanBeEnumerable.Local
            {
                get { return _cachedMembers ?? (_cachedMembers = QueryMembers()); }
            }

            static KeyValuePair<string, ulong>[] QueryMembers()
            {
                var names = System.Enum.GetNames(typeof(T));
                var values = System.Enum.GetValues(typeof(T));
                var members = new KeyValuePair<string, ulong>[names.Length];
                for (var i = 0; i < members.Length; i++)
                    members[i] = new KeyValuePair<string, ulong>(names[i], ((IConvertible)values.GetValue(i)).ToUInt64(null));
                return members;
            }

            public static T? TryParse(string value, StringComparison comparison)
            {
                if (!typeof(T).GetTypeInfo().IsEnum)
                    throw new Exception(String.Format("{0} is not an enumeration type.", typeof(T).FullName));

                var type = typeof(T);
                if (value == null)
                    return null;

                value = value.Trim();
                if (value.Length == 0)
                    return null;

                var ch = value[0];
                if ((ch >= '0' && ch <= '9') || ch == '-' || ch == '+')
                {
                    var underlyingType = System.Enum.GetUnderlyingType(type);
                    try
                    {
                        var obj = Convert.ChangeType(value, underlyingType, CultureInfo.InvariantCulture);
                        Debug.Assert(obj != null);
                        return (T)System.Enum.ToObject(type, obj);
                    }
                    catch (FormatException) { /* ignore */ }
                    catch (Exception)
                    {
                        return null;
                    }
                }

                var result = 0UL;
                var tokens = value.Split(StringSeparatorStock.Comma);

                foreach (var t in tokens)
                {
                    var token = t.Trim();
                    var match = default(KeyValuePair<string, ulong>);
                    foreach (var member in Members)
                    {
                        if (member.Key.Equals(token, comparison))
                        {
                            match = member;
                            break;
                        }
                    }
                    if (match.Key == null)
                        return null;
                    result |= match.Value;
                }

                try
                {
                    return (T)System.Enum.ToObject(type, result);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        // Uri

        public static Uri Uri(string uriString, UriKind uriKind)
        {
            Uri result;
            return System.Uri.TryCreate(uriString, uriKind, out result) ? result : null;
        }

        public static Uri Uri(Uri baseUri, string relativeUri)
        {
            Uri result;
            return System.Uri.TryCreate(baseUri, relativeUri, out result) ? result : null;
        }

        public static Uri Uri(Uri baseUri, Uri relativeUri)
        {
            Uri result;
            return System.Uri.TryCreate(baseUri, relativeUri, out result) ? result : null;
        }
    }
}
