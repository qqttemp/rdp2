using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest
{
    public class NetworkClient
    {
        private const int TIMEOUT = 10000;
        private const string HTTP_GET = "GET";
        private const string HTTP_POST = "POST";
        private const string HTTP_DELETE = "DELETE";
        private const string CONTENTTYPE_FORM = "application/x-www-form-urlencoded";
        private const string CONTENTTYPE_JSON = "application/json";

        private static readonly HttpClient HttpClient;

        public string Url { get; set; }

        private string _ContentType;
        public ContentTypeEnum ContentType
        {
            set
            {
                switch (value)
                {
                    case ContentTypeEnum.Form:
                        _ContentType = CONTENTTYPE_FORM;
                        break;
                    case ContentTypeEnum.Json:
                        _ContentType = CONTENTTYPE_JSON;
                        break;
                    default:
                        throw new Exception($"不支持的ContentTypeEnum{value}");
                }
            }
        }

        static NetworkClient()
        {
            HttpClient = new HttpClient();
        }

        public NetworkClient(string url)
        {
            Headers = new Dictionary<string, string>();
            _ContentType = CONTENTTYPE_JSON;
            Url = url;
        }

        public Dictionary<string, string> Headers { get; }

        public string HttpDelete()
        {
            using (HttpWebResponse response=HttpWebResponse(Url,HTTP_DELETE, null))
            {
                using (Stream myResponseStream = response.GetResponseStream())
                {
                    using (StreamReader myStreamReader = new StreamReader(myResponseStream))
                    {
                        return myStreamReader.ReadToEnd();
                    }
                }
            }
        }

        public string HttpPost()
        {
            var httpclient = NetworkClient.HttpClient;
            var data = Encoding.ASCII.GetBytes(postData);
            using (HttpClient http = new HttpClient())
            {
                HttpResponseMessage message = null;
                using (Stream dataStream = new MemoryStream(data ?? new byte[0]))
                {
                    using (HttpContent content = new StreamContent(dataStream))
                    {
                        foreach (var key in Headers.Keys)
                        {
                            content.Headers.Add(key, Headers[key]);
                        }
                        content.Headers.Add("Content-Type", _ContentType);
                        message = http.PostAsync(Url, content).GetAwaiter().GetResult();
                    }
                }
                return new ResponseMessage()
                {
                    StatusCode = message.StatusCode,
                    Result = message.Content.ReadAsStringAsync().Result
                };
            }
        }

        public ResponseMessage HttpGet()
        {
            string result = "";
            var httpclient = NetworkClient.HttpClient;

            var response = httpclient.GetAsync(Url).Result;

            using (Stream myResponseStream = response.Content.ReadAsStreamAsync().Result)
            {
                using (StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8")))
                {
                    result = myStreamReader.ReadToEnd();
                }
            }

            return new ResponseMessage()
            {
                StatusCode = response.StatusCode,
                Result = result
            };
        }

        private void AddHeader(HttpWebRequest request)
        {
            foreach (var key in Headers.Keys)
            {
                request.Headers.Add(key, Headers[key]);
            }
        }

        public enum ContentTypeEnum
        {
            Form,
            Json
        }
    }
}
