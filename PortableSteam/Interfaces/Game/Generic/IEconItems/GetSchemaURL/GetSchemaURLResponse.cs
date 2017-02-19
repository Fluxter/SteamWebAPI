namespace PortableSteam.Interfaces.Game.Generic.IEconItems
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Converters;
    using System.Collections.Generic;

    public class GetSchemaURLResponse : ResponseBase
    {
        [JsonProperty("result")]
        public GetSchemaURLResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSchemaURLResponseData
    {
        /// <summary>
        /// The status of the request, should always be 1.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
        /// <summary>
        /// URL of the items_game.txt file.
        /// </summary>
        [JsonProperty("items_game_url")]
        public string ItemsGameUrl { get; set; }
    }
}
