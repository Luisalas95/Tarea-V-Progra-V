namespace QuickType
{
    using System.Collections.Generic;
    using System;
    using System.Linq;
    using System.Web;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Login
    {
        [JsonProperty("identifiacion")]
        public string identificacion { get; set; }

        [JsonProperty("password")]
        public string password { get; set; }
    }
    public partial class Login
    {
        public static List<Login> FromJson(string json) => JsonConvert.DeserializeObject<List<Login>>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Login self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
