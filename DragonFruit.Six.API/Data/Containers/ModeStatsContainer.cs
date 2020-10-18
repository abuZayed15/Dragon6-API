﻿// Dragon6 API Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under Apache-2. Please refer to the LICENSE file for more info

using System;
using DragonFruit.Six.API.Utils;
using Newtonsoft.Json;

namespace DragonFruit.Six.API.Data.Containers
{
    public class ModeStatsContainer
    {
        private float? _wl;
        private TimeSpan? _timePlayed;

        [JsonProperty("wins")]
        public uint Wins { get; set; }

        [JsonProperty("losses")]
        public uint Losses { get; set; }

        [JsonProperty("total_matches")]
        public uint MatchesPlayed { get; set; }

        [JsonProperty("highscore")]
        public uint Highscore { get; set; }

        [JsonProperty("wl")]
        public float Wl => _wl ??= RatioUtils.RatioOf(Wins, Losses);

        [JsonIgnore]
        internal uint Duration { get; set; }

        [JsonProperty("time_played")]
        public TimeSpan TimePlayed => _timePlayed ??= TimeSpan.FromSeconds(Duration);
    }
}
