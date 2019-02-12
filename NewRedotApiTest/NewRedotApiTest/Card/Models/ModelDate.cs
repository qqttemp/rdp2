using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Card.Models
{
    public class ModelDate
    {
        /// <summary>
        /// A RFC3339 timestamp
        /// </summary>
        [JsonProperty("created")]
        public string Created { get; set; }
    }
}
