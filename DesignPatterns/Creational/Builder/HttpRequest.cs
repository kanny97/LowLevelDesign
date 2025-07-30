using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class HttpRequest
    {
        //Required
        private readonly string Url;

        //Optional
        private readonly string Method;
        private readonly Dictionary<string, string> QueryParameters;
        private readonly Dictionary<string, string> Headers;
        private readonly string Body;
        private readonly int TimeOut;

        private HttpRequest(Builder builder)
        {
            Url = builder.Url;
            Method = builder.Method;
            QueryParameters = builder.QueryParameters;
            Headers = builder.Headers;
            Body = builder.Body;
            TimeOut = builder.TimeOut;
        }

        public override string ToString()
        {
            return $"HttpRequest {{ Url='{Url}', Method='{Method}', Headers={Headers.Count}, QueryParams={QueryParameters.Count}, Body='{Body}'}}";
        }

        public class Builder
        {
            //Required
            public readonly string Url;

            //Optional
            public string Method = "GET";
            public readonly Dictionary<string, string> QueryParameters = new Dictionary<string, string>();
            public readonly Dictionary<string, string> Headers = new Dictionary<string, string>();
            public string Body = string.Empty;
            public int TimeOut = 30000;

            public Builder(string url)
            {
                if (string.IsNullOrEmpty(url))
                {
                    throw new ArgumentException("URL cannot be null or empty");
                }
                Url = url;
            }
            public Builder SetMethod(string method)
            {
                Method = method;
                return this;
            }
            public Builder AddQueryParameter(string key, string value)
            {
                QueryParameters[key] = value;
                return this;
            }
            public Builder AddHeader(string key, string value)
            {
                Headers[key] = value;
                return this;
            }
            public Builder SetBody(string body)
            {
                Body = body;
                return this;
            }
            public Builder SetTimeOut(int timeOut)
            {
                if (timeOut <= 0)
                {
                    throw new ArgumentException("Timeout must be greater than zero");
                }
                TimeOut = timeOut;
                return this;
            }
            public HttpRequest Build()
            {
                return new HttpRequest(this);
            }
        }
    }
}
