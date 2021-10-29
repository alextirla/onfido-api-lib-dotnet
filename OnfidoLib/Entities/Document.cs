using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;

namespace OnfidoLib.Entities
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DocumentType {
        [Description("passport")]
        [EnumMember(Value = "passport")]
        Passport,
        [Description("national_identity_card")]
        [EnumMember(Value = "national_identity_card")]
        NationalIdentityCard,
        [Description("work_permit")]
        [EnumMember(Value = "work_permit")]
        WorkPermit,
        [Description("driving_licence")]
        [EnumMember(Value = "driving_licence")]
        DrivingLicence,                                      
        [Description("voter_id")]
        [EnumMember(Value = "voter_id")]
        VoterId,
        [Description("unknown")]
        [EnumMember(Value = "unknown")]
        Unknown
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DocumentSide
    {
        [Description("front")]
        Front, 
        [Description("back")]
        Back
    }

    public class Document
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("created_at")]
        public DateTime CreatedAt;

        [JsonProperty("href")]
        public string HRef;

        [JsonProperty("file_name")]
        public string FileName;

        [JsonProperty("file_type")]
        public string FileType;

        [JsonProperty("file_size")]
        public int FileSize;

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DocumentType Type;

        [JsonProperty("side")]
        public DocumentSide? Side;
    }
}
