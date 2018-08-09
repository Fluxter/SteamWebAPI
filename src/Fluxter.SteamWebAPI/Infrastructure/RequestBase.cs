// ------------------------------------------------------------------------------------------------
//  <copyright file="RequestBase.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Infrastructure
{
    using System;
    using Objects;

    /// <summary>
    ///     Base class for steam requests.
    /// </summary>
    public abstract class RequestBase
    {
        private readonly string _key;

        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="key"></param>
        protected RequestBase(string key)
        {
            this._key = key;
        }

        /// <summary>
        ///     The file format to return output in.
        /// </summary>
        public RequestFormat Format { get; set; }

        /// <summary>
        ///     The ISO639-1 language code for the language all tokenized strings should be returned in.
        ///     Not all strings have been translated to every language.
        ///     If a language does not have a string, the English string will be returned instead.
        ///     If this parameter is omitted the string token will be returned for the strings.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        ///     Base URL for MapQuest API.
        /// </summary>
        protected internal abstract string EndpointUrl { get; }

        /// <summary>
        ///     The complete URI of this request with parameters.
        /// </summary>
        /// <returns></returns>
        public Uri GetUri()
        {
            if (string.IsNullOrEmpty(this._key))
            {
                throw new ArgumentNullException("Developer key cannot be null or empty.");
            }

            return new Uri(string.Format("{0}?key={1}&{2}", this.EndpointUrl, this._key,
                this.GetParameterList().ToQueryString()));
        }

        /// <summary>
        ///     List of parameters for this request object.
        /// </summary>
        /// <returns></returns>
        protected virtual QueryStringDictionary GetParameterList()
        {
            var parameters = new QueryStringDictionary();

            if (string.IsNullOrEmpty(this.Language))
            {
                this.Language = "en-US";
            }

            parameters.Add("language", this.Language);
            parameters.Add("format", this.Format.ToNullableString());
            return parameters;
        }
    }
}