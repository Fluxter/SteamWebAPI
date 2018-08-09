// ------------------------------------------------------------------------------------------------
//  <copyright file="Dota2GameMode.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI
{
    /// <summary>
    ///     Dota 2 game modes.
    /// </summary>
    public enum Dota2GameMode
    {
        /// <summary>
        ///     None.
        /// </summary>
        None,

        /// <summary>
        ///     All pick.
        /// </summary>
        AllPick,

        /// <summary>
        ///     Captain's mode.
        /// </summary>
        CaptainsMode,

        /// <summary>
        ///     Random draft.
        /// </summary>
        RandomDraft,

        /// <summary>
        ///     Single draft.
        /// </summary>
        SingleDraft,

        /// <summary>
        ///     All random.
        /// </summary>
        AllRandom,

        /// <summary>
        ///     Intro.
        /// </summary>
        Intro,

        /// <summary>
        ///     Dire tide.
        /// </summary>
        Diretide,

        /// <summary>
        ///     Reverse captain's mode.
        /// </summary>
        ReverseCaptainsMode,

        /// <summary>
        ///     The greeviling.
        /// </summary>
        TheGreeviling,

        /// <summary>
        ///     Tutorial.
        /// </summary>
        Tutorial,

        /// <summary>
        ///     Mid lane only.
        /// </summary>
        MidOnly,

        /// <summary>
        ///     Least played.
        /// </summary>
        LeastPlayed,

        /// <summary>
        ///     New player pool.
        /// </summary>
        NewPlayerPool,

        /// <summary>
        ///     Compendium match making.
        /// </summary>
        CompendiumMatchmaking,

        /// <summary>
        ///     Captain's draft.
        /// </summary>
        CaptainsDraft
    }
}