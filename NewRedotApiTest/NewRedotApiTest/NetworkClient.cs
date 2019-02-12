using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest
{
    public class NetworkClient
    {
        private const int TIMEOUT = 1000;
        private const string HTTP_GET = "GET";
        private const string HTTP_POST = "POST";
        private const string CONTENTTYPE_FORM = "application/x-www-form-urlencoded";
        private const string CONTENTTYPE_JSON = "application/json";


        public string Url { get; set; }
        public string PostData { get; set; }

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

        public NetworkClient(string url)
        {
            Headers = new Dictionary<string, string>();
            _ContentType = CONTENTTYPE_JSON;
            Url = url;
        }

        public Dictionary<string, string> Headers { get; }

        public string HttpPost()
        {
            using (HttpWebResponse response = HttpWebResponse(Url, HTTP_POST, PostData))
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

        public string HttpGet()
        {
            using (HttpWebResponse response = HttpWebResponse(Url, HTTP_GET, null))
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

        private HttpWebResponse HttpWebResponse(string url, string method, string postData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            AddHeader(request);
            request.ContentType = _ContentType;
            request.Method = method;
            request.AllowAutoRedirect = false;
            request.Timeout = TIMEOUT;

            if (string.IsNullOrWhiteSpace(postData))
            {
                request.ContentLength = 0;
            }
            else
            {
                using (Stream myRequestStream = request.GetRequestStream())
                {
                    using (StreamWriter myStreamWriter = new StreamWriter(myRequestStream))
                    {
                        myStreamWriter.Write(postData);
                    }
                }
            }
            try
            {
                return (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                return (HttpWebResponse)ex.Response;
            }
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
