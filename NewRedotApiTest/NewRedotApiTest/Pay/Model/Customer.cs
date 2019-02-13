using Newtonsoft.Json;

namespace NewRedotApiTest.Pay.Model
{
    public class Customer
    {
        /// <summary>
        /// Card token's resource identifier in the format of rid:card:token/<id>
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// Email address to send payment result
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Phone number to send payment result
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("ip")]
        public IpAddress Ip { get; set; }

        /// <summary>
        /// Browser header as JSON string
        /// </summary>
        [JsonProperty("header")]
        public string Header { get; set; }
    }


}
