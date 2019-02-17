using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblia.Models
{
    public class Biblia
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        [JsonProperty("module")]
        public string Module { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("lang_short")]
        public string LangShort { get; set; }

        [JsonProperty("copyright")]
        public long Copyright { get; set; }

        [JsonProperty("italics")]
        public long Italics { get; set; }

        [JsonProperty("strongs")]
        public long Strongs { get; set; }

        [JsonProperty("red_letter")]
        public long RedLetter { get; set; }

        [JsonProperty("paragraph")]
        public long Paragraph { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("research")]
        public long Research { get; set; }
    }
}
