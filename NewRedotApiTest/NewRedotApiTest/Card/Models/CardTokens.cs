using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Card.Models
{
    public class CardTokens
    {
        /// <summary>
        /// 返回的卡片总数
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("cards")]
        public TokenCard[] TokenCards { get; set; }
    }

    public class TokenCard
    {
        /// <summary>
        /// The id of a card in hash SHA256
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Holds the different tokens of the card
        /// </summary>
        [JsonProperty("tokens")]
        public Token[] Tokens { get; set; }
    }

    public class Token
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public TokenLink[] Links { get; set; }
    }

    public class TokenLink
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }
    }
}
