namespace PortableSteam.Interfaces.General.ISteamEconomy
{
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Objects;

    public class GetAssetClassInfoRequest : RequestBase
    {
        public GetAssetClassInfoRequest(string key) : base(key) { }
        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamEconomy/GetAssetClassInfo/v0001/"; }
        }
        public int AppID { get; set; }
        public int ClassCount { get; set; }
        public int[] ClassIDs { get; set; }
        public int[] InstanceIDs { get; set; }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", AppID);
            parameters.Add("class_count", ClassCount);

            for (int i = 0; i < ClassIDs.Length; i++)
            {
                parameters.Add("classid" + i, ClassIDs[i]);
            }

            if (InstanceIDs != null)
            {
                for (int i = 0; i < InstanceIDs.Length; i++)
                {
                    parameters.Add("instanceid" + i, InstanceIDs[i]);
                }
            }

            return parameters;
        }
    }
}
