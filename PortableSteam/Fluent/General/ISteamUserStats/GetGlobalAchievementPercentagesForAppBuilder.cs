namespace PortableSteam.Fluent.General.ISteamUserStats
{
    using PortableSteam.Interfaces.General.ISteamUserStats;
    using System;
    using System.ComponentModel;

    public class GetGlobalAchievementPercentagesForAppBuilder : SteamBaseBuilder<GetGlobalAchievementPercentagesForAppRequest, GetGlobalAchievementPercentagesForAppResponse, GetGlobalAchievementPercentagesForAppBuilder>
    {
        public GetGlobalAchievementPercentagesForAppBuilder(GetGlobalAchievementPercentagesForAppRequest request) : base(request) { }

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
