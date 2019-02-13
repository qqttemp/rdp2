using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Card.Models
{
    public class RenewCard
    {
        /// <summary>
        /// Token expiry in Unix timestamp format. Omitting this field or sending 0 will set the expiry time to 3 months from today.
        /// </summary>
        [JsonProperty("expires")]
        public int? Expires { get; set; }
    }
}
