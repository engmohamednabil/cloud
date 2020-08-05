using System;
using Newtonsoft.Json;

namespace SunlightApp.Models
{
    public partial class SunriseSunsetDataModel
    {
        [JsonProperty("results")]
        public Results Results { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public partial class Results
    {
        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }
    }
}
