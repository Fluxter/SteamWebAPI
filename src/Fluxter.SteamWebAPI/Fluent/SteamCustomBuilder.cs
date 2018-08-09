// ------------------------------------------------------------------------------------------------
//  <copyright file="SteamCustomBuilder.cs"
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
    using System.Threading.Tasks;
    using Infrastructure;

    public class SteamCustomBuilder
    {
        private readonly CustomRequest _request;

        public SteamCustomBuilder(CustomRequest request)
        {
            this._request = request;
        }

        /// <summary>
        ///     Gets the response string of this request.
        /// </summary>
        /// <param name="format">Format of the response string. Default is JSON.</param>
        /// <returns>Response string.</returns>
        public string GetResponseString(RequestFormat format = RequestFormat.JSON)
        {
            this._request.Format = format;
            return RequestHandler.Request(this._request.GetUri());
        }

        /// <summary>
        ///     Gets the response string of this request asynchronously.
        /// </summary>
        /// <param name="format">Format of the response string. Default is JSON.</param>
        /// <returns>Response string.</returns>
        public async Task<string> GetResponseStringAsync(RequestFormat format = RequestFormat.JSON)
        {
            this._request.Format = format;
            return await RequestHandler.RequestAsync(this._request.GetUri());
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