using System;
using Newtonsoft.Json;

namespace SunlightApp.Models
{
    public partial class sunlightDataModel
    {
        [JsonProperty("num")]
        public long Num { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

        [JsonProperty("img")]
        public Uri Img { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
