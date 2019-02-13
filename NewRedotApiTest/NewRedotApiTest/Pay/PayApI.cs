using NewRedotApiTest.Pay.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Pay
{
    public class PayApI
    {
        // public string PayAPIBaseUrl = "https://cardpay.api.reddotpay.sg/v1";

        public string PayAPIBaseUrl = "http://localhost:61848";

        public Order Authorize(NewOrder newOrder)
        {
            string url = $"{PayAPIBaseUrl}/order";
            NetworkClient networkClient = new NetworkClient(url);

            var response = networkClient.HttpPost(JsonConvert.SerializeObject(newOrder));

            return ConvertToOrderResult(response, "请求授权");
        }

        public Order Capture(string orderId, CurrencyAmount capture)
        {
            string url = $"{PayAPIBaseUrl}/order/{orderId}/capture";
            NetworkClient networkClient = new NetworkClient(url);

            var response = networkClient.HttpPost(JsonConvert.SerializeObject(capture));

            return ConvertToOrderResult(response, "请款");
        }

        public Order Refund(string orderId, CurrencyAmount refund)
        {
            string url = $"{PayAPIBaseUrl}/order/{orderId}/refund";
            NetworkClient networkClient = new NetworkClient(url);
            var response = networkClient.HttpPost(JsonConvert.SerializeObject(refund));
            return ConvertToOrderResult(response, "退款");
        }

        public Order Chargeback(string orderId)
        {
            string url = $"{PayAPIBaseUrl}/order/{orderId}/chargeback";
            NetworkClient networkClient = new NetworkClient(url);
            var response = networkClient.HttpPost(null);
            return ConvertToOrderResult(response, "拒付");
        }

        public Order RetrieveOrder(string orderId)
        {
            string url = $"{PayAPIBaseUrl}/order/{orderId}";
            NetworkClient networkClient = new NetworkClient(url);
            var response = networkClient.HttpGet();
            return ConvertToOrderResult(response, $"检索订单{orderId}");
        }

        private Order ConvertToOrderResult(ResponseMessage response, string action)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.Created)
                return JsonConvert.DeserializeObject<Order>(response.Result);
            else
                throw new Exception($"{action}失败：{response.StatusCode.ToString()}({(int)response.StatusCode}),{response.Result}");
        }
    }
}
