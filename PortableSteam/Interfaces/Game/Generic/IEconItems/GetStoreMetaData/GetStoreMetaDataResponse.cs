namespace PortableSteam.Interfaces.Game.Generic.IEconItems
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Converters;
    using System.Collections.Generic;

    /// <summary>
    /// TODO.
    /// </summary>
    public class GetStoreMetaDataResponse : ResponseBase
    {
        [JsonProperty("result")]
        public GetStoreMetaDataResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetStoreMetaDataResponseData
    {
    }
}
