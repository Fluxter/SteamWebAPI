using PortableSteam.Infrastructure.Objects;
namespace PortableSteam.Infrastructure
{
    public class CustomRequest : RequestBase
    {
        private QueryStringDictionary _parameters;
        public CustomRequest(string key) : base(key) { }
        public string Interface { get; set; }
        public string Method { get; set; }
        public string Version { get; set; }
        public QueryStringDictionary Parameters
        {
            get
            {
                if (_parameters == null)
                {
                    _parameters = new QueryStringDictionary();
                }
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/{0}/{1}/{2}", Interface, Method, Version); }
        }
        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.AddRange(Parameters);
            return parameters;
        }
    }
}
