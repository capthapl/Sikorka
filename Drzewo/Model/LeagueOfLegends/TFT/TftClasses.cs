using System;
using Newtonsoft.Json;

namespace Drzewo.Model.LeagueOfLegends.TFT
{
    public class TftClasses
    {
        [JsonProperty("assassin")]
        public ClassType Assassin { get; set; }

        [JsonProperty("blademaster")]
        public ClassType Blademaster { get; set; }

        [JsonProperty("brawler")]
        public ClassType Brawler { get; set; }

        [JsonProperty("elementalist")]
        public ClassType Elementalist { get; set; }

        [JsonProperty("guardian")]
        public ClassType Guardian { get; set; }

        [JsonProperty("gunslinger")]
        public ClassType Gunslinger { get; set; }

        [JsonProperty("knight")]
        public ClassType Knight { get; set; }

        [JsonProperty("ranger")]
        public ClassType Ranger { get; set; }

        [JsonProperty("shapeshifter")]
        public ClassType Shapeshifter { get; set; }

        [JsonProperty("sorcerer")]
        public ClassType Sorcerer { get; set; }
    }

    public class ClassType
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

    public partial class Bonus
    {
        [JsonProperty("needed")]
        public long Needed { get; set; }

        [JsonProperty("effect")]
        public string Effect { get; set; }
    }
}
