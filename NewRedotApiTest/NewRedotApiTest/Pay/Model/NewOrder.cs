using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Pay.Model
{
    public class NewOrder
    {
        /// <summary>
        /// Merchant’s reference id,alphanumeric 16 characters long.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Transaction description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Amount to authorize 
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// ISO 4217 alphabetic code
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        ///  Merchant's resource identifier in the format of rid:mam:merchant/<id>
        /// </summary>
        [JsonProperty("merchant")]
        public string Merchant { get; set; }

        /// <summary>
        /// The FDS call back url.
        /// </summary>
        [JsonProperty("fdsCallback")]
        public string FdsCallback { get; set; }

        /// <summary>
        /// 3DSecure's resource identifier in the format of rid:3dsecure:process/<id> (id, The return id when enrolling). This is required to perform 3DSecure.
        /// </summary>
        [JsonProperty("3DSecure")]
        public string Secure3D { get; set; }

        /// <summary>
        /// Merchant's account resource identifier in the format of rid:mam:account/<id>. This is required to perform 3DSecure.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// If the first authorization is successful, you can submit subsequent authorizations for recurring payments using that card token by setting 'true' on the field. If the first authorization is not successful, do not submit subsequent authorizations using that card token.
        /// </summary>
        [JsonProperty("recurring")]
        public bool Recurring { get; set; }

        /// <summary>
        /// customer
        /// </summary>
        [JsonProperty("customer")]
        public Customer Customer { get; set; }
    }
}
