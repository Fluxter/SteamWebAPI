namespace PortableSteam.Fluent
{
    using PortableSteam.Infrastructure;
    using System;
    using System.ComponentModel;
    using System.Threading.Tasks;

    public class SteamCustomBuilder
    {
        private CustomRequest _request;
        public SteamCustomBuilder(CustomRequest request)
        {
            _request = request;
        }
        /// <summary>
        /// Gets the response string of this request.
        /// </summary>
        /// <param name="format">Format of the response string. Default is JSON.</param>
        /// <returns>Response string.</returns>
        public string GetResponseString(RequestFormat format = RequestFormat.JSON)
        {
            _request.Format = format;
            return RequestHandler.Request(_request.GetUri());
        }
        /// <summary>
        /// Gets the response string of this request asynchronously.
        /// </summary>
        /// <param name="format">Format of the response string. Default is JSON.</param>
        /// <returns>Response string.</returns>
        public async Task<string> GetResponseStringAsync(RequestFormat format = RequestFormat.JSON)
        {
            _request.Format = format;
            return await RequestHandler.RequestAsync(_request.GetUri());
        }

        #region Hidden

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
        #endregion
    }
}
