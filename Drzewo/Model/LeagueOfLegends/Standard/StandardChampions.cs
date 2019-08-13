using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drzewo.Model.LeagueOfLegends.Standard
{
    public class StandardChampions
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, ChampionDetails> Data { get; set; }
    }

    public partial class ChampionDetails
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public long Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("partype")]
        public Partype Partype { get; set; }

        [JsonProperty("stats")]
        public Dictionary<string, double> Stats { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("full")]
        public string Full { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("attack")]
        public long Attack { get; set; }

        [JsonProperty("defense")]
        public long Defense { get; set; }

        [JsonProperty("magic")]
        public long Magic { get; set; }

        [JsonProperty("difficulty")]
        public long Difficulty { get; set; }
    }

    public enum Partype { Battlefury, BloodWell, Dragonfury, Energy, Ferocity, Gnarfury, Heat, Mp, None, Rage, Wind };

    public enum Tag { Assassin, Fighter, Mage, Marksman, Melee, Support, Tank };

}
