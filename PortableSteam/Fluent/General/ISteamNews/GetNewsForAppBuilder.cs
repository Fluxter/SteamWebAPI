namespace PortableSteam.Fluent.General.ISteamNews
{
    using PortableSteam.Fluent;
    using PortableSteam.Infrastructure;
    using PortableSteam.Interfaces.General.ISteamNews;
    using System;
    using System.ComponentModel;

    public class GetNewsForAppBuilder : SteamBaseBuilder<GetNewsForAppRequest, GetNewsForAppResponse, GetNewsForAppBuilder>
    {
        public GetNewsForAppBuilder(GetNewsForAppRequest request) : base(request) { }
        /// <summary>
        /// The max length of the contents field.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetNewsForAppBuilder MaxLength(int value)
        {
            this.Request.MaxLength = value;
            return this;
        }
        /// <summary>
        /// Returns posts before this date.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetNewsForAppBuilder EndDate(DateTime value)
        {
            this.Request.EndDate = (int)value.ToUnixTimeStamp();
            return this;
        }
        /// <summary>
        /// The max number of news items to retrieve. Default: 20.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetNewsForAppBuilder Count(int value)
        {
            this.Request.Count = value;
            return this;
        }
        /// <summary>
        /// List of feed names to return news for.
        /// </summary>
        /// <param name="feeds"></param>
        /// <returns></returns>
        public GetNewsForAppBuilder Feeds(params string[] feeds)
        {
            this.Request.Feeds = feeds.ToDelimitedString(",");
            return this;
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
