using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Card.Models
{
    public class ModelExpiry
    {
        /// <summary>
        /// 2-digits month
        /// </summary>
        [JsonProperty("month")]
        public string Month { get; set; }

        /// <summary>
        /// 4-digits year
        /// </summary>
        [JsonProperty("year")]
        public string Year { get; set; }
    }
}
