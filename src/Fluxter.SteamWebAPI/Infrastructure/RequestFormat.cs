// ------------------------------------------------------------------------------------------------
//  <copyright file="RequestFormat.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI
{
    /// <summary>
    ///     The file format to return output in.
    /// </summary>
    public enum RequestFormat
    {
        /// <summary>
        ///     The JavaScript Object Notation format.
        /// </summary>
        JSON,

        /// <summary>
        ///     Valve Data Format.
        /// </summary>
        /// <remarks>
        ///     http://wiki.teamfortress.com/wiki/WebAPI/VDF
        /// </remarks>
        VDF,

        /// <summary>
        ///     Standard XML.
        /// </summary>
        XML
    }
}