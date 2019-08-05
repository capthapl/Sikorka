using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drzewo.Model.LeagueOfLegends.Standard
{
    public class StandardProfileIcon
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, IconDetails> Data { get; set; }
    }

    public partial class IconDetails
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("image")]
        public ProfileImage Image { get; set; }
    }

    public partial class ProfileImage
    {
        [JsonProperty("full", NullValueHandling = NullValueHandling.Ignore)]
        public string Full { get; set; }
    }
}
