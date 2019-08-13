using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Drzewo.Model.LeagueOfLegends.Standard
{
    public class StandardItems
    {
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("basic", NullValueHandling = NullValueHandling.Ignore)]
        public Basic Basic { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ItemDetails> Data { get; set; }

        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public Group[] Groups { get; set; }

        [JsonProperty("tree", NullValueHandling = NullValueHandling.Ignore)]
        public Tree[] Tree { get; set; }
    }

    public partial class Basic
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("rune", NullValueHandling = NullValueHandling.Ignore)]
        public Rune Rune { get; set; }

        [JsonProperty("gold", NullValueHandling = NullValueHandling.Ignore)]
        public Gold Gold { get; set; }

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        private string _description;
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description
        {
            get
            {
                return Regex.Replace(_description, "<.*?>", String.Empty);
            }
            set
            {
                _description = value;
            }
        }

        [JsonProperty("colloq", NullValueHandling = NullValueHandling.Ignore)]
        public string Colloq { get; set; }

        [JsonProperty("plaintext", NullValueHandling = NullValueHandling.Ignore)]
        public string Plaintext { get; set; }

        [JsonProperty("consumed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Consumed { get; set; }

        [JsonProperty("stacks", NullValueHandling = NullValueHandling.Ignore)]
        public long? Stacks { get; set; }

        [JsonProperty("depth", NullValueHandling = NullValueHandling.Ignore)]
        public long? Depth { get; set; }

        [JsonProperty("consumeOnFull", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConsumeOnFull { get; set; }

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public object[] From { get; set; }

        [JsonProperty("into", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Into { get; set; }

        [JsonProperty("specialRecipe", NullValueHandling = NullValueHandling.Ignore)]
        public long? SpecialRecipe { get; set; }

        [JsonProperty("inStore", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InStore { get; set; }

        [JsonProperty("hideFromAll", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideFromAll { get; set; }

        [JsonProperty("requiredChampion", NullValueHandling = NullValueHandling.Ignore)]
        public string RequiredChampion { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> Stats { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Tags { get; set; }

        [JsonProperty("maps", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool> Maps { get; set; }
    }

    public partial class Gold
    {
        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public long? Base { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }

        [JsonProperty("sell", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sell { get; set; }

        [JsonProperty("purchasable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Purchasable { get; set; }
    }

    public partial class Rune
    {
        [JsonProperty("isrune", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isrune { get; set; }

        [JsonProperty("tier", NullValueHandling = NullValueHandling.Ignore)]
        public long? Tier { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class ItemDetails
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        private string _description;
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description {
            get {
                return Regex.Replace(_description, "<.*?>", " ");
            }
            set {
                _description = value;
            }
        }

        [JsonProperty("colloq", NullValueHandling = NullValueHandling.Ignore)]
        public string Colloq { get; set; }

        [JsonProperty("plaintext", NullValueHandling = NullValueHandling.Ignore)]
        public string Plaintext { get; set; }

        [JsonProperty("into", NullValueHandling = NullValueHandling.Ignore)]
        public long[] Into { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public ItemImage Image { get; set; }

        [JsonProperty("gold", NullValueHandling = NullValueHandling.Ignore)]
        public Gold Gold { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Tags { get; set; }

        [JsonProperty("maps", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool> Maps { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, double> Stats { get; set; }

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public long[] From { get; set; }

        [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
        public Effect Effect { get; set; }

        [JsonProperty("depth", NullValueHandling = NullValueHandling.Ignore)]
        public long? Depth { get; set; }

        [JsonProperty("consumed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Consumed { get; set; }

        [JsonProperty("stacks", NullValueHandling = NullValueHandling.Ignore)]
        public long? Stacks { get; set; }

        [JsonProperty("inStore", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InStore { get; set; }

        [JsonProperty("consumeOnFull", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConsumeOnFull { get; set; }

        [JsonProperty("requiredChampion", NullValueHandling = NullValueHandling.Ignore)]
        public string RequiredChampion { get; set; }

        [JsonProperty("specialRecipe", NullValueHandling = NullValueHandling.Ignore)]
        public long? SpecialRecipe { get; set; }

        [JsonProperty("hideFromAll", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideFromAll { get; set; }
    }

    public partial class Effect
    {
        [JsonProperty("Effect1Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect1Amount { get; set; }

        [JsonProperty("Effect2Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect2Amount { get; set; }

        [JsonProperty("Effect3Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect3Amount { get; set; }

        [JsonProperty("Effect4Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect4Amount { get; set; }

        [JsonProperty("Effect5Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect5Amount { get; set; }

        [JsonProperty("Effect6Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect6Amount { get; set; }

        [JsonProperty("Effect7Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect7Amount { get; set; }

        [JsonProperty("Effect8Amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect8Amount { get; set; }
    }

    public partial class ItemImage
    {
        [JsonProperty("full", NullValueHandling = NullValueHandling.Ignore)]
        public string Full { get; set; }
    }

    public class Group
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("MaxGroupOwnable")]
        public long? MaxGroupOwnable { get; set; }
    }

    public class Tree
    {
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public string Header { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Tags { get; set; }
    }
}
