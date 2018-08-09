// ------------------------------------------------------------------------------------------------
//  <copyright file="Extensions.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Objects;

    public static class Extensions
    {
        /// <summary>
        ///     Returns this object as a string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToNullableString(this object source)
        {
            string value = string.Empty;

            if (source != null)
            {
                if (!string.IsNullOrEmpty(source.ToString()))
                {
                    value = source.ToString().Trim();
                }
            }

            return value;
        }

        /// <summary>
        ///     Returns this object as a string all lower case.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToLowerString(this object source)
        {
            return source.ToNullableString().ToLower();
        }

        /// <summary>
        ///     Converts this unix time stamp to date time.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this long source)
        {
            DateTime value = new DateTime(1970, 1, 1, 0, 0, 0);
            value = value.AddSeconds(source).ToLocalTime();
            return value;
        }

        /// <summary>
        ///     Converts this date time to unix time stamp.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static long ToUnixTimeStamp(this DateTime source)
        {
            return (long) (source - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
        }

        /// <summary>
        ///     Converts this ienumerable source to a delimited string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static string ToDelimitedString<T>(this IEnumerable<T> source, string delimiter)
        {
            return string.Join(delimiter, source);
        }

        /// <summary>
        ///     Converts this object's parameters to a query string dictionary.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static QueryStringDictionary ToDictionary(this object source)
        {
            var dictionary = new QueryStringDictionary();
            var properties = source.GetType().GetRuntimeProperties();

            foreach (var property in properties)
            {
                var key = property.Name.ToLower();
                var value = property.GetValue(source, null);

                if (!string.IsNullOrEmpty(key) && value != null)
                {
                    dictionary.Add(key, value);
                }
            }

            return dictionary;
        }
    }
}