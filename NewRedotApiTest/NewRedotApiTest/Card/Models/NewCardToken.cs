using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Card.Models
{
    public class NewCardToken
    {
        [JsonProperty("token")]
        public NewToken Token { get; set; }

        /// <summary>
        /// Token expiry in Unix timestamp format
        /// </summary>
        [JsonProperty("expires")]
        public int? Expires { get; set; }

        /// <summary>
        /// A RFC3339 timestamp fomat of the created token
        /// </summary>
        [JsonProperty("date")]
        public ModelDate Date { get; set; }

        [JsonProperty("links")]
        public ModelLinks[] Links { get; set; }
    }

    public class NewToken
    {
        /// <summary>
        /// Card token id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
