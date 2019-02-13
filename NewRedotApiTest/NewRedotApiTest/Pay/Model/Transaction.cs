using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Pay.Model
{
    public class Transaction
    {
        /// <summary>
        /// TransactionStatusEnum
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Ledger Resource ID
        /// </summary>
        [JsonProperty("ledger")]
        public string Ledger { get; set; }

        /// <summary>
        /// Amount authorized 
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Currency authorized 
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The action of the transaction, refer to enum values for the accepted values Action values: <see cref="TransactionAction"/>
        /// </summary> 
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// The status of the transaction action
        /// </summary>
        [JsonProperty("status")]
        public TransactionStatusEnum Status { get; set; }

        /// <summary>
        /// The authorisation code after completing an authorise action.
        /// </summary>
        [JsonProperty("authcode")]
        public string Authcode { get; set; }

        /// <summary>
        /// True indicates the transaction has been void
        /// </summary>
        [JsonProperty("void")]
        public bool Void { get; set; }

        [JsonProperty("date")]
        public OrderDate Date { get; set; }
    }

    public class TransactionAction
    {
        /// <summary>
        ///  To place transaction payment funds on hold.
        /// </summary>
        public const string Authorize = "authorize";

        /// <summary>
        /// To charge the transaction funds manually
        /// </summary>
        public const string Capture = "capture";

        /// <summary>
        /// To refund the charged transaction funds
        /// </summary>
        public const string Refund = "refund";

        /// <summary>
        /// To automatically authorize and capture transaction. 
        /// </summary>
        public const string AutoCapture = "auto-capture";

        /// <summary>
        /// To reverse to the previous action.
        /// </summary>
        public const string Void = "void";

        /// <summary>
        /// To close an order.
        /// </summary>
        public const string Close = "close";
    }

    public enum TransactionStatusEnum
    {
        /// <summary>
        /// Indicates the action has failed
        /// </summary>
        fail,
        /// <summary>
        /// Indicates the action has succeeded.
        /// </summary>
        success,
    }
}
