using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Drzewo.Model.LeagueOfLegends.TFT
{
    public class TftItems
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("bonus")]
        public string Bonus { get; set; }

        [JsonProperty("tier")]
        public long Tier { get; set; }

        [JsonProperty("depth")]
        public long Depth { get; set; }

        [JsonProperty("stats")]
        public Stat[] Stats { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("buildsInto")]
        public string[] BuildsInto { get; set; }

        [JsonProperty("champs")]
        public string[] Champs { get; set; }
    }

    public class Stat
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }
    }
}



