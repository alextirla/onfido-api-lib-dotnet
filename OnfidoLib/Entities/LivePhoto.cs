using Newtonsoft.Json;
using System;

namespace OnfidoLib.Entities
{
    public class LivePhoto
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("created_at")]
        public DateTime CreatedAt;

        [JsonProperty("href")]
        public string HRef;

        [JsonProperty("download_href")]
        public string DownloadHRef;

        [JsonProperty("file_name")]
        public string FileName;

        [JsonProperty("file_type")]
        public string FileType;

        [JsonProperty("file_size")]
        public int FileSize;
    }
}
