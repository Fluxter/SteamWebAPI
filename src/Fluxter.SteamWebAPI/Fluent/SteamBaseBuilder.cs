// ------------------------------------------------------------------------------------------------
//  <copyright file="SteamBaseBuilder.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent
{
    using System;
    using System.ComponentModel;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Infrastructure;
    using Newtonsoft.Json;

    public class SteamBaseBuilder<TRequest, TResponse, TBuilder>
        where TRequest : RequestBase
        where TResponse : ResponseBase, new()
        where TBuilder : SteamBaseBuilder<TRequest, TResponse, TBuilder>
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="request"></param>
        public SteamBaseBuilder(TRequest request)
        {
            this.Request = request;
        }

        /// <summary>
        ///     The current request.
        /// </summary>
        protected TRequest Request { get; }

        /// <summary>
        ///     Gets the response object of this request.
        /// </summary>
        /// <returns>Response object.</returns>
        public virtual TResponse GetResponse()
        {
            try
            {
                // Serialize
                var json = this.GetResponseString();
                var response = JsonConvert.DeserializeObject<TResponse>(json);
                response.RequestURI = this.Request.GetUri();

                if (response.Response == null)
                {
                    response.Response = new Response {Success = true};
                }

                return response;
            }
            catch (Exception ex)
            {
                if (ex is AggregateException && ex.InnerException != null && ex.InnerException is HttpRequestException)
                {
                    return new TResponse
                    {
                        RequestURI = this.Request.GetUri(),
                        Response = new Response {Error = "Internal Server Error", Success = false, ErrorCode = 500}
                    };
                }

                throw ex;
            }
        }

        /// <summary>
        ///     Gets the response object of this request asynchronously.
        /// </summary>
        /// <returns>Response object.</returns>
        public virtual async Task<TResponse> GetResponseAsync()
        {
            try
            {
                // Serialize
                string json = await this.GetResponseStringAsync();
                var response = JsonConvert.DeserializeObject<TResponse>(json);
                response.RequestURI = this.Request.GetUri();

                if (response.Response == null)
                {
                    response.Response = new Response {Success = true};
                }

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///     The ISO639-1 language code for the language all tokenized strings should be returned in.
        ///     Not all strings have been translated to every language.
        ///     If a language does not have a string, the English string will be returned instead.
        ///     If this parameter is omitted the string token will be returned for the strings.
        /// </summary>
        /// <see href="http://en.wikipedia.org/wiki/List_of_ISO_639-1_codes" />
        /// <param name="language"></param>
        /// <returns></returns>
        public TBuilder Language(string language)
        {
            this.Request.Language = language;
            return this as TBuilder;
        }

        /// <summary>
        ///     Gets the response string of this request.
        /// </summary>
        /// <param name="format">Format of the response string. Default is JSON.</param>
        /// <returns>Response string.</returns>
        public string GetResponseString(RequestFormat format = RequestFormat.JSON)
        {
            this.Request.Format = format;
            return RequestHandler.Request(this.Request.GetUri());
        }

        /// <summary>
        ///     Gets the response string of this request asynchronously.
        /// </summary>
        /// <param name="format">Format of the response string. Default is JSON.</param>
        /// <returns>Response string.</returns>
        public async Task<string> GetResponseStringAsync(RequestFormat format = RequestFormat.JSON)
        {
            this.Request.Format = format;
            return await RequestHandler.RequestAsync(this.Request.GetUri());
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return this.GetType();
        }
    }
}