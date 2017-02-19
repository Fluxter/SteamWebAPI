namespace PortableSteam.Interfaces.General.ISteamUser
{
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Objects;

    public class ResolveVanityURLRequest : RequestBase
    {
        public ResolveVanityURLRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUser/ResolveVanityURL/v1"; }
        }

        public string VanityUrl { get; set; }
        public RelationshipType Relationship { get; set; }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("vanityurl", VanityUrl);
            return parameters;
        }
    }
}
