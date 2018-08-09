// ------------------------------------------------------------------------------------------------
//  <copyright file="QueryStringKeyValuePair.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Infrastructure.Objects
{
    /// <summary>
    ///     Key value pair used for QueryStringDictionary.
    /// </summary>
    public class QueryStringKeyValuePair
    {
        public QueryStringKeyValuePair(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        ///     Key of this pair.
        /// </summary>
        public string Key { get; }

        /// <summary>
        ///     Value of this pair.
        /// </summary>
        public object Value { get; }
    }
}