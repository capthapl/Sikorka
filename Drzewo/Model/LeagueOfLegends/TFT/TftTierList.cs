using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Drzewo.Model.LeagueOfLegends.TFT
{
    public class TftTierList
    {
        [JsonProperty("all")]
        public Dictionary<string, string[]> All { get; set; }

        [JsonProperty("early")]
        public Dictionary<string, string[]> Early { get; set; }

        [JsonProperty("mid")]
        public Dictionary<string, string[]> Mid { get; set; }

        [JsonProperty("late")]
        public Dictionary<string, string[]> Late { get; set; }
    }
}
