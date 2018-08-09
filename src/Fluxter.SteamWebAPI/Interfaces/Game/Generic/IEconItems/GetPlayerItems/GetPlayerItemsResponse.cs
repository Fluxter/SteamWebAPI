// ------------------------------------------------------------------------------------------------
//  <copyright file="GetPlayerItemsResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Generic.IEconItems.GetPlayerItems
{
    using System.Collections.Generic;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;
    using Types;

    public class GetPlayerItemsResponse : ResponseBase
    {
        [JsonProperty("result")] public GetPlayerItemsResponseData Data { get; set; }

        public enum ResponseStatus
        {
            Success = 1,
            InvalidSteamID = 8,
            Private = 15,
            SteamIDDoesNotExist = 18
        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetPlayerItemsResponseData
    {
        /// <summary>
        ///     The status of the request.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(JsonEnumConverter<GetPlayerItemsResponse.ResponseStatus>))]
        public GetPlayerItemsResponse.ResponseStatus Status { get; set; }

        /// <summary>
        ///     The number of backpack slots this user has.
        /// </summary>
        [JsonProperty("num_backpack_slots")]
        public int NumBackpackSlots { get; set; }

        /// <summary>
        ///     A list of item objects.
        /// </summary>
        [JsonProperty("items")]
        public List<GetPlayerItemsResponseItem> Items { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetPlayerItemsResponseItem
    {
        /// <summary>
        ///     The unique ID of the specific item.
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        ///     The ID of the item before it was customized, traded, or otherwise changed.
        /// </summary>
        [JsonProperty("original_id")]
        public int OriginalID { get; set; }

        /// <summary>
        ///     The defindex of the item, as found in the item array returned from GetSchema.
        /// </summary>
        [JsonProperty("defindex")]
        public int DefIndex { get; set; }

        /// <summary>
        ///     The arbitrary "level" value of the item as displayed in the inventory.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        ///     The number of "uses" an item has, generally only has a value in excess of '1' on "usable items", such as the
        ///     Dueling Mini-Game.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        ///     An integer used to lookup an origin name via GetSchema.
        /// </summary>
        [JsonProperty("origin")]
        public int? Origin { get; set; }

        /// <summary>
        ///     A boolean value that is true if the item cannot be traded. Assume false if not present.
        /// </summary>
        [JsonProperty("flag_cannot_trade")]
        public bool? FlagCannotTrade { get; set; }

        /// <summary>
        ///     A boolean value that is true if the item cannot be used in crafting. Assume false if not present.
        /// </summary>
        [JsonProperty("flag_cannot_craft")]
        public bool? FlagCannotCraft { get; set; }

        /// <summary>
        ///     The quality of the item (see definition in GetSchema).
        /// </summary>
        [JsonProperty("quality")]
        [JsonConverter(typeof(JsonEnumConverter<EconItemsQuality>))]
        public EconItemsQuality Quality { get; set; }

        /// <summary>
        ///     The item's custom name if it has one.
        /// </summary>
        [JsonProperty("custom_name")]
        public string CustomName { get; set; }

        /// <summary>
        ///     The item's custom description if it has one.
        /// </summary>
        [JsonProperty("custom_desc")]
        public string CustomDescription { get; set; }

        /// <summary>
        ///     All the information for the item that this item contains for gift-wrapped items.
        /// </summary>
        [JsonProperty("contained_item")]
        public string ContainedItem { get; set; }

        /// <summary>
        ///     An integer that can be used as an index to the item's style list.
        /// </summary>
        [JsonProperty("style")]
        public int? Style { get; set; }

        /// <summary>
        ///     If the item has additional effects to the ones normally associated with it as described in GetSchema, contains a
        ///     list of objects.
        /// </summary>
        [JsonProperty("attributes")]
        public List<GetPlayerItemsResponseAttribute> Attributes { get; set; }

        /// <summary>
        ///     If the item is equipped, contains an array of equip information
        /// </summary>
        [JsonProperty("equipped")]
        public List<GetPlayerItemsResponseEquipment> Equipped { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetPlayerItemsResponseAttribute
    {
        /// <summary>
        ///     The index to the attributes definition in the schema, e.g. 133 for the medal number attribute for the Gentle
        ///     Manne's Service Medal.
        /// </summary>
        [JsonProperty("defindex")]
        public int DefIndex { get; set; }

        /// <summary>
        ///     The value for this attribute for this item, e.g. the medal number for the Gentle Manne's Service Medal.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        ///     The floating point value for this attribute if it has one.
        /// </summary>
        [JsonProperty("float_value ")]
        public double? FloatValue { get; set; }

        /// <summary>
        ///     Set on attributes with a Steam ID as the value.
        /// </summary>
        [JsonProperty("account_info")]
        public GetPlayerItemsResponseAccountInfo AccountInfo { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetPlayerItemsResponseAccountInfo
    {
        /// <summary>
        ///     The specified user's identity.
        /// </summary>
        [JsonProperty("steamid")]
        [JsonConverter(typeof(JsonSteamIdentityConverter))]
        public SteamIdentity Identity { get; set; }

        /// <summary>
        ///     The specified user's current name on Steam.
        /// </summary>
        [JsonProperty("personaname")]
        public string PersonaName { get; set; }
    }

    /// <summary>
    ///     http://wiki.teamfortress.com/wiki/WebAPI/GetPlayerItems#cite_ref-tf2specific_1-1
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetPlayerItemsResponseEquipment
    {
        /// <summary>
        ///     The class the weapon is equipped to (numeric index).
        /// </summary>
        [JsonProperty("class")]
        public int Class { get; set; }

        /// <summary>
        ///     The slot the weapon is equipped in (numeric index).
        /// </summary>
        [JsonProperty("slot")]
        public int Slot { get; set; }
    }
}