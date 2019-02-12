using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Card.Models
{
    public class NewCard
    {
        /// <summary>
        /// Merchant’s resource identifier in the format rid:mam:merchant/<id> rid - (Resource Identifier) To identify a particular resource in the RDP APIs.
        /// </summary>
        [JsonProperty("merchant")]
        public string Merchant { get; set; }

        /// <summary>
        /// The card number
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("expiry")]
        public ModelExpiry Expiry { get; set; }

        /// <summary>
        /// Specify token expiry in Unix timestamp format
        /// </summary>
        [JsonProperty("expires")]
        public int? Expires { get; set; }

        /// <summary>
        /// 3-digits or 4-digits code depending on card brand
        /// </summary>
        [JsonProperty("cvv")]
        public string Cvv { get; set; }

        /// <summary>
        /// The card holder name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public ModelAddress Address { get; set; }
    }

}
