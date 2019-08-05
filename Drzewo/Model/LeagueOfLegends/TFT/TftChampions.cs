using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drzewo.Model.LeagueOfLegends.TFT
{
    public class TftChampions
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("origin")]
        public string[] Origin { get; set; }

        [JsonProperty("class")]
        public string[] Class { get; set; }

        [JsonProperty("cost")]
        public long Cost { get; set; }

        [JsonProperty("ability")]
        public Ability Ability { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("items")]
        public string[] Items { get; set; }
    }

    public partial class Ability
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("manaCost", NullValueHandling = NullValueHandling.Ignore)]
        public long? ManaCost { get; set; }

        [JsonProperty("manaStart", NullValueHandling = NullValueHandling.Ignore)]
        public long? ManaStart { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public AbilityStats[] Stats { get; set; }
    }

    public class AbilityStats
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Stats
    {
        [JsonProperty("offense")]
        public Offense Offense { get; set; }

        [JsonProperty("defense")]
        public Defense Defense { get; set; }
    }

    public class Defense
    {
        [JsonProperty("health")]
        public long Health { get; set; }

        [JsonProperty("armor")]
        public long Armor { get; set; }

        [JsonProperty("magicResist")]
        public long MagicResist { get; set; }
    }

    public class Offense
    {
        [JsonProperty("damage")]
        public long Damage { get; set; }

        [JsonProperty("attackSpeed")]
        public double AttackSpeed { get; set; }

        [JsonProperty("dps")]
        public long Dps { get; set; }

        [JsonProperty("range")]
        public long Range { get; set; }
    }
}
