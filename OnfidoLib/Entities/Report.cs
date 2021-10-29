using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OnfidoLib.Entities
{
    public class Report
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("created_at")]
        public DateTime CreatedAt;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("variant")]
        public string Variant;

        [JsonProperty("result")]
        public string Result;

        [JsonProperty("sub_results")]
        public string SubResult;

        [JsonProperty("href")]
        public string HRef;

        [JsonProperty("check_id")]
        public string CheckId;

        [JsonProperty("documents")]
        public IEnumerable<string> DocumentsId;

        [JsonProperty("breakdown")]
        public Dictionary<string, string> Breakdown;

        [JsonProperty("properties")]
        public Dictionary<string, string> Properties;
    }
}
