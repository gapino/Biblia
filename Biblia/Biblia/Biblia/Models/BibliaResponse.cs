using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblia.Models
{
    public class BibliaResponse
    {
        [JsonProperty("error_level")]
        public long ErrorLevel { get; set; }

        [JsonProperty("results")]
        public Dictionary<string, Biblia> Biblias { get; set; }
    }
}
