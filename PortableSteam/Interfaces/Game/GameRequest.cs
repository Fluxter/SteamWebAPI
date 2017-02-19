namespace PortableSteam.Interfaces.Game
{
    using PortableSteam.Infrastructure;

    public abstract class GameRequest : RequestBase
    {
        private int _appID;
        protected int AppID { get { return _appID; } }
        protected GameRequest(string key, int appID)
            : base(key)
        {
            _appID = appID;
        }
    }
}
