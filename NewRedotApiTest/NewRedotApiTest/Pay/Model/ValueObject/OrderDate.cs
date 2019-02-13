using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Pay.Model
{
    public class OrderDate
    {

        /// <summary>
        /// The timestamp of the transaction being created in the format of RFC3339
        /// </summary>
        /// 
        [JsonProperty("created")]
        public string Created { get; set; }
    }
}
