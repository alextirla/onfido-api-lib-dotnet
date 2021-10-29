using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OnfidoLib.Entities
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportsType
    {
        [Description("document")]
        Document,
        [Description("facial_similarity_photo")]
        Facial
    }

    public class Check
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("applicant_id")]
        public string ApplicantId;

        [JsonProperty("created_at")]
        public DateTime CreatedAt;

        [JsonProperty("href")]
        public string HRef;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("result")]
        public string Result;

        [JsonProperty("results_uri")]
        public string ResultsUri;

        [JsonProperty("form_uri")]
        public string FormUri;

        [JsonProperty("sandbox")]
        public string Sandbox;

        [JsonProperty("report_ids")]
        public IEnumerable<string> Reports;

        [JsonProperty("report_names")]
        public IEnumerable<string> ReportNames;
    }
}
