// ------------------------------------------------------------------------------------------------
//  <copyright file="GetStoreMetaDataResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Generic.IEconItems.GetStoreMetaData
{
    using Infrastructure;
    using Newtonsoft.Json;

    /// <summary>
    ///     TODO.
    /// </summary>
    public class GetStoreMetaDataResponse : ResponseBase
    {
        [JsonProperty("result")] public GetStoreMetaDataResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetStoreMetaDataResponseData
    {
    }
}