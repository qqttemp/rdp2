using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NewRedotApiTest.Pay.Model
{
    public class Order
    {
        /// <summary>
        /// An unique ID for an order
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        /// <summary>
        /// Total authorize amount  for the transaction
        /// </summary>
        /// 
        [JsonProperty("authorize")]
        public CurrencyAmount Authorize { get; set; }

        /// <summary>
        /// Total capture amount  for the transaction
        /// </summary>
        /// 
        [JsonProperty("capture")]
        public CurrencyAmount Capture { get; set; }

        /// <summary>
        /// Total refunded amount for the transaction
        /// </summary>
        [JsonProperty("refund")]
        public CurrencyAmount Refund { get; set; }

        /// <summary>
        /// Description of the order items
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The state of the order
        /// </summary>
        [JsonProperty("state")]
        public StateEnum State { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }

        [JsonProperty("date")]
        public OrderDate Date { get; set; }
    }

    public enum StateEnum
    {
        /// <summary>
        ///  The transaction payment funds are placed on hold. 
        /// </summary>
        authorize,

        /// <summary>
        ///  The state where the funds are being charged
        /// </summary>
        capture,

        /// <summary>
        /// The charged funds are being refunded
        /// </summary>
        refund,

        /// <summary>
        /// The transaction is being rejected. 
        /// </summary>
        reject,

        /// <summary>
        /// The order is close to prevent payer from proceeding with their order.
        /// </summary>
        close
    }

    public class Account
    {
        /// <summary>
        /// Account's resource identifier in the format of rid:mam:account/<id> (id, The id of the account used for the transaction)
        /// </summary>
        [JsonProperty("rid")]
        public string Rid { get; set; }

        /// <summary>
        /// Account type. Example 'mpgs','cybersource'
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
    
}
