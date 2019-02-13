using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Card.Models
{
    public class NewRepo
    {
        /// <summary>
        /// Unique repository name
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Merchant resource of which the repository belongs to
        /// </summary>
        [JsonProperty("merchant")]
        public string Merchant { get; set; }
    }
}
