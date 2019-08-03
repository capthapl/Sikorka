using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Drzewo.Model.LeagueOfLegends.TFT
{
    public class TftOrigins
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("accentChampionImage")]
        public Uri AccentChampionImage { get; set; }

        [JsonProperty("bonuses")]
        public Bonus[] Bonuses { get; set; }
    }
}
