namespace PortableSteam.Interfaces.Game.Generic.IEconItems
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Converters;
    using System.Collections.Generic;

    /// <summary>
    /// TODO.
    /// </summary>
    public class GetSchemaResponse : ResponseBase
    {
        [JsonProperty("result")]
        public GetSchemaResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSchemaResponseData
    {
        /// <summary>
        /// The status of the request, should always be 1.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
        /// <summary>
        /// A string containing the URL to the full item schema as used by the game.
        /// </summary>
        [JsonProperty("items_game_url")]
        public string ItemsGameUrl { get; set; }
        /// <summary>
        /// A list of item objects.
        /// </summary>
        [JsonProperty("items")]
        public List<GetSchemaResponseItem> Items { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSchemaResponseItem
    {
    }
}
