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

        public static bool? Boolean(string value) =>
            bool.TryParse(value, out var result) ? result : (bool?)null;

        // SByte

        [CLSCompliant(false)]
        public static sbyte? SByte(string s) =>
            sbyte.TryParse(s, out var result) ? result : (sbyte?)null;

        [CLSCompliant(false)]
        public static sbyte? SByte(string s, NumberStyles style, IFormatProvider provider) =>
            sbyte.TryParse(s, style, provider, out var result) ? result : (sbyte?)null;

        // Byte

        public static byte? Byte(string s) =>
            byte.TryParse(s, out var result) ? result : (byte?)null;

        public static byte? Byte(string s, NumberStyles style, IFormatProvider provider) =>
            byte.TryParse(s, style, provider, out var result) ? result : (byte?)null;

        // Int16

        public static short? Int16(string s) =>
            short.TryParse(s, out var result) ? result : (short?)null;

        public static short? Int16(string s, NumberStyles style, IFormatProvider provider) =>
            short.TryParse(s, style, provider, out var result) ? result : (short?)null;

        // UInt16

        [CLSCompliant(false)]
        public static ushort? UInt16(string s) =>
            ushort.TryParse(s, out var result) ? result : (ushort?)null;

        [CLSCompliant(false)]
        public static ushort? UInt16(string s, NumberStyles style, IFormatProvider provider) =>
            ushort.TryParse(s, style, provider, out var result) ? result : (ushort?)null;

        // Int32

        public static int? Int32(string s) =>
            int.TryParse(s, out var result) ? result : (int?)null;

        public static int? Int32(string s, NumberStyles style, IFormatProvider provider) =>
            int.TryParse(s, style, provider, out var result) ? result : (int?)null;

        // UInt32

        [CLSCompliant(false)]
        public static uint? UInt32(string s) =>
            uint.TryParse(s, out var result) ? result : (uint?)null;

        [CLSCompliant(false)]
        public static uint? UInt32(string s, NumberStyles style, IFormatProvider provider) =>
            uint.TryParse(s, style, provider, out var result) ? result : (uint?)null;

        // Int64

        public static long? Int64(string s) =>
            long.TryParse(s, out var result) ? result : (long?)null;

        public static long? Int64(string s, NumberStyles style, IFormatProvider provider) =>
            long.TryParse(s, style, provider, out var result) ? result : (long?)null;

        // UInt64

        [CLSCompliant(false)]
        public static ulong? UInt64(string s) =>
            ulong.TryParse(s, out var result) ? result : (ulong?)null;

        [CLSCompliant(false)]
        public static ulong? UInt64(string s, NumberStyles style, IFormatProvider provider) =>
            ulong.TryParse(s, style, provider, out var result) ? result : (ulong?)null;

        // Single

        public static float? Single(string s) =>
            float.TryParse(s, out var result) ? result : (float?)null;

        public static float? Single(string s, NumberStyles style, IFormatProvider provider) =>
            float.TryParse(s, style, provider, out var result) ? result : (float?)null;

        // Double

        public static double? Double(string s) =>
            double.TryParse(s, out var result) ? result : (double?)null;

        public static double? Double(string s, NumberStyles style, IFormatProvider provider) =>
            double.TryParse(s, style, provider, out var result) ? result : (double?)null;

        // Decimal

        public static decimal? Decimal(string s) =>
            decimal.TryParse(s, out var result) ? result : (decimal?)null;

        public static decimal? Decimal(string s, NumberStyles style, IFormatProvider provider) =>
            decimal.TryParse(s, style, provider, out var result) ? result : (decimal?)null;

        // TimeSpan

        public static TimeSpan? TimeSpan(string s) =>
            System.TimeSpan.TryParse(s, out var result) ? result : (TimeSpan?)null;

        // DateTime

        public static DateTime? DateTime(string s) =>
            System.DateTime.TryParse(s, out var result) ? result : (DateTime?)null;

        public static DateTime? DateTime(string s, IFormatProvider provider, DateTimeStyles styles) =>
            System.DateTime.TryParse(s, provider, styles, out var result) ? result : (DateTime?)null;

        public static DateTime? DateTimeExact(string s, string format, IFormatProvider provider, DateTimeStyles styles) =>
            System.DateTime.TryParseExact(s, format, provider, styles, out var result) ? result : (DateTime?)null;

        public static DateTime? DateTimeExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles) =>
            System.DateTime.TryParseExact(s, formats, provider, styles, out var result) ? result : (DateTime?)null;

        // DateTimeOffset

        public static DateTimeOffset? DateTimeOffset(string input) =>
            System.DateTimeOffset.TryParse(input, out var result) ? result : (DateTimeOffset?)null;

        public static DateTimeOffset? DateTimeOffset(string input, IFormatProvider formatProvider, DateTimeStyles styles) =>
            System.DateTimeOffset.TryParse(input, formatProvider, styles, out var result) ? result : (DateTimeOffset?)null;

        public static DateTimeOffset? DateTimeOffsetExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) =>
            System.DateTimeOffset.TryParseExact(input, format, formatProvider, styles, out var result) ? result : (DateTimeOffset?)null;

        public static DateTimeOffset? DateTimeOffsetExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles) =>
            System.DateTimeOffset.TryParseExact(input, formats, formatProvider, styles, out var result) ? result : (DateTimeOffset?)null;

        // Enum

        public static T? Enum<T>(string value) where T : struct =>
            Enum<T>(value, false);

        public static T? Enum<T>(string value, bool ignoreCase) where T : struct =>
            EnumImpl<T>.TryParse(value, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);

        static class StringSeparatorStock
        {
            public static readonly char[] Comma = { ',' };
        }

        static class EnumImpl<T> where T : struct
        {                                                        // ReSharper disable StaticFieldInGenericType
            static KeyValuePair<string, ulong>[] _cachedMembers; // ReSharper restore StaticFieldInGenericType
                                                                 // ReSharper disable ReturnTypeCanBeEnumerable.Local
            static KeyValuePair<string, ulong>[] Members =>      // ReSharper restore ReturnTypeCanBeEnumerable.Local
                _cachedMembers ?? (_cachedMembers = QueryMembers());

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
                    throw new Exception(string.Format("{0} is not an enumeration type.", typeof(T).FullName));

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

        public static Uri Uri(string uriString, UriKind uriKind) =>
            System.Uri.TryCreate(uriString, uriKind, out var result) ? result : null;

        public static Uri Uri(Uri baseUri, string relativeUri) =>
            System.Uri.TryCreate(baseUri, relativeUri, out var result) ? result : null;

        public static Uri Uri(Uri baseUri, Uri relativeUri) =>
            System.Uri.TryCreate(baseUri, relativeUri, out var result) ? result : null;
    }
}
