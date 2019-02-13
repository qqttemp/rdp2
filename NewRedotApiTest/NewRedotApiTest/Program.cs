using NewRedotApiTest.Pay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest
{
    class Program
    {
        public static string rid = "QQTTEST";
       // public static string merchant = "rdptest86";
        public static string merchant = "1007778122";
        //public static string merchant = "RDP Test 86";

        public static string CardAPIBaseUrl = "https://card.api.reddotpay.sg/v1";
        public static string CardPayBaseUrl = "https://cardpay.api.reddotpay.sg/v1";

        static void Main(string[] args)
        {
            PayApI payApI = new PayApI();
//            var orders = payApI.Authorize(new Pay.Model.NewOrder() { Amount = 1});
            var order = payApI.Capture("111",new Pay.Model.CurrencyAmount() { Amount =2,Currency="CNY" });
            Console.ReadKey();
        }

        public static void Ping()
        {
            try
            {
                string url = $"{CardAPIBaseUrl}/ping";
                var client = new NetworkClient(url);
                client.HttpGet();
                Console.WriteLine($"ping成功");
            }
            catch (Exception err)
            {
                Console.WriteLine($"ping失败:{err.Message}");
            }
        }

        public static void CreateRepository()
        {
            string url = $"{CardAPIBaseUrl}/repo";
            var client = new NetworkClient(url);
            client.Headers.Add("Authorization", "siJwZUgWezHz0bXPALgi6d4JuYISeDJsxQWjQBah");
            //client.Headers.Add("x-api-key", "siJwZUgWezHz0bXPALgi6d4JuYISeDJsxQWjQBah");
            //client.Headers.Add("Authorization", "peZc6I6YeA8wsfR8U1xtHCqpAa7LN14i0Q06ZyYR");
            //client.Headers.Add("x-api-key", "peZc6I6YeA8wsfR8U1xtHCqpAa7LN14i0Q06ZyYR");
            //client.Headers.Add("Authorization", "3B4OeQA1y6ofBWkKy1XzV17t6kShSV84sKeymRStUo6GXhN1DYiYuCUQoZzx6OrpAzqfVTuOMTalPWXrpk3oesnDg76uY3l9vzzqGOlUuig0fwzL0ooU2ythYpNGCJ2h");
            //client.Headers.Add("x-api-key", "3B4OeQA1y6ofBWkKy1XzV17t6kShSV84sKeymRStUo6GXhN1DYiYuCUQoZzx6OrpAzqfVTuOMTalPWXrpk3oesnDg76uY3l9vzzqGOlUuig0fwzL0ooU2ythYpNGCJ2h");
            //client.Headers.Add("Authorization", "EJU9ecjOyCsBBIc3Td4H3TFQ2RLUNnvQirgNMeqZiXqkYiDqQ4IBBP8CIMfgPi687Fwzqr5OG3Ufzayxi4ghGZxJwRHfIkX0pAZdQQ3XWUgTBspHBb0leyp1AIdNzsdr");
            // client.Headers.Add("x-api-key", "EJU9ecjOyCsBBIc3Td4H3TFQ2RLUNnvQirgNMeqZiXqkYiDqQ4IBBP8CIMfgPi687Fwzqr5OG3Ufzayxi4ghGZxJwRHfIkX0pAZdQQ3XWUgTBspHBb0leyp1AIdNzsdr");
            var result = client.HttpPost(null);
            Console.WriteLine(result);
        }

    }
}
