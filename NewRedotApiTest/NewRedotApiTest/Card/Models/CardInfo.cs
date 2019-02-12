using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Card.Models
{
    public class CardInfo
    {
        /// <summary>
        /// A hash SHA256 of the card number
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The card number/A masked card number
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// The brand of the card, listed are the accepted brands
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("expiry")]
        public ModelExpiry Expiry { get; set; }

        /// <summary>
        /// 3-digits or 4-digits depending on card brand
        /// </summary>
        [JsonProperty("ccv")]
        public string Ccv { get; set; }

        /// <summary>
        /// The name on the card
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public ModelAddress Address { get; set; }

        /// <summary>
        /// A RFC3339 timestamp format of the created card
        /// </summary>
        [JsonProperty("date")]
        public ModelDate Date { get; set; }

        [JsonProperty("links")]
        public ModelLinks[] Links { get; set; }
    }
}
