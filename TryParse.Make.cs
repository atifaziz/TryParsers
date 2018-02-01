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

    static partial class TryParse
    {
        /// <summary>
        /// Creates and returns a function that returns the default value of
        /// <typeparamref name="T"/> whenever the supplied parser function
        /// throws an exception and the parsed value otherwise.
        /// </summary>

        public static Func<string, T> Make<T>(Func<string, T> parser)
        {
            return Make(parser, default(T));
        }

        /// <summary>
        /// Creates and returns a function that returns a user-defined
        /// default value whenever the supplied parser function throws an
        /// exception and the parsed value otherwise.
        /// </summary>

        public static Func<string, T> Make<T>(Func<string, T> parser, T defaultValue)
        {
            return Make(parser, _ => defaultValue);
        }

        /// <summary>
        /// Creates and returns a function that returns the result of a
        /// parser function and the result of a second function if the
        /// parser function throws an exception.
        /// </summary>

        public static Func<string, T> Make<T>(Func<string, T> parser, Func<Exception, T> onError)
        {
            return Make<T, Exception>(parser, onError);
        }

        /// <summary>
        /// Creates and returns a function that returns the result of a
        /// parser function and the result of a second function if the
        /// parser function throws an exception of type
        /// <typeparamref name="TException"/>. Exceptions of any other type
        /// are propagated.
        /// </summary>

        public static Func<string, T> Make<T, TException>(
            Func<string, T> parser,
            Func<TException, T> onError)
            where TException : Exception
        {
            return input =>
            {
                try
                {
                    return parser(input);
                }
                catch (TException e)
                {
                    return onError(e);
                }
            };
        }

        /// <summary>
        /// Creates and returns a function that returns the result of a
        /// parser function and the result of a second or third function if
        /// the parser function throws an exception of type
        /// <typeparamref name="TException1"/> or
        /// <typeparamref name="TException2"/>, respectively.
        /// Exceptions of any other type are propagated.
        /// </summary>

        public static Func<string, T> Make<T, TException1, TException2>(
            Func<string, T> parser,
            Func<TException1, T> onError1,
            Func<TException2, T> onError2)
            where TException1 : Exception
            where TException2 : Exception
        {
            return input =>
            {
                try
                {
                    return parser(input);
                }
                catch (TException1 e)
                {
                    return onError1(e);
                }
                catch (TException2 e)
                {
                    return onError2(e);
                }
            };
        }

        /// <summary>
        /// Creates and returns a function that returns the result of a
        /// parser function and the result of a second, third or fourth
        /// function if  the parser function throws an exception of type
        /// <typeparamref name="TException1"/> or
        /// <typeparamref name="TException2"/> or
        /// <typeparamref name="TException3"/>, respectively.
        /// Exceptions of any other type are propagated.
        /// </summary>

        public static Func<string, T> Make<T, TException1, TException2, TException3>(
            Func<string, T> parser,
            Func<TException1, T> onError1,
            Func<TException2, T> onError2,
            Func<TException3, T> onError3)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
        {
            return input =>
            {
                try
                {
                    return parser(input);
                }
                catch (TException1 e)
                {
                    return onError1(e);
                }
                catch (TException2 e)
                {
                    return onError2(e);
                }
                catch (TException3 e)
                {
                    return onError3(e);
                }
            };
        }
    }
}
