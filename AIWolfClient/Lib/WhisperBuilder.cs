﻿//
// WhisperBuilder.cs
//
// Copyright (c) 2016 Takashi OTSUKI
//
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//


using AIWolf.Lib;

namespace AIWolf.Client.Lib
{
    /// <summary>
    /// Class to create whisper contents.
    /// </summary>
    public class WhisperBuilder : TalkBuilder
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="gameInfo">The game information.</param>
        public WhisperBuilder(GameInfo gameInfo) : base(gameInfo)
        {
        }

        /// <summary>
        /// Returns the whisper about attack.
        /// </summary>
        /// <param name="target">The agent the whisperer wants to attack.</param>
        /// <returns>Whisper about attack.</returns>
        /// <remarks>If the given target agent is invalid, this method throws AIWolfAgentException.</remarks>
        public string Attack(Agent target)
        {
            CheckTarget("Attack", target);
            return Topic.ATTACK.ToString() + " " + target.ToString();
        }
    }
}