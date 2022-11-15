namespace ConsumeApis.Clases

{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Usuario
    {
        [JsonProperty("identifiacion")]
        public string identificacion { get; set; }

        [JsonProperty("nombre")]
        public string nombre { get; set; }

        [JsonProperty("apelldios")]
        public string apellidos { get; set; }

        [JsonProperty("password")]
        public string password { get; set; }


    }
    public partial class Usuario
    {
        public static List<Usuario> FromJson(string json) => JsonConvert.DeserializeObject<List<Usuario>>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Usuario self) => JsonConvert.SerializeObject(self, Clases.Converter.Settings);
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
