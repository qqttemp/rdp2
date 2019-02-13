using Newtonsoft.Json;

namespace NewRedotApiTest.Pay.Model
{
    public class IpAddress
    {
        [JsonProperty("v4")]
        public string V4 { get; set; }

        [JsonProperty("v6")]
        public string V6 { get; set; }
    }
}
