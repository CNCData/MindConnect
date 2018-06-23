using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient
{
    public class HttpRequestBuilder
    {
        private HttpMethod method = null;
        private string requestUri = "";
        private string uriQueryString = null;
        private HttpContent content = null;
        private string bearerToken = "";
        private string acceptHeader = "application/json";
        private string userAgent = "MindConnectCSharpAPI";
        private TimeSpan timeout = new TimeSpan(0, 0, 15);
        private bool allowAutoRedirect = false;

        public HttpRequestBuilder()
        {
        }

        public HttpRequestBuilder AddMethod(HttpMethod method)
        {
            this.method = method;
            return this;
        }
        
        public HttpRequestBuilder AddRequestUri(string requestUri)
        {
            this.requestUri = requestUri;
            return this;
        }

        public HttpRequestBuilder AddUriQueryString(Dictionary<String, String> uriQueryString)
        {
            this.uriQueryString = uriQueryString.ToString();
            return this;
        }

        public HttpRequestBuilder AddContent(HttpContent content)
        {
            this.content = content;
            return this;
        }

        public HttpRequestBuilder AddBearerToken(string bearerToken)
        {
            this.bearerToken = bearerToken;
            return this;
        }

        public HttpRequestBuilder AddAcceptHeader(string acceptHeader)
        {
            this.acceptHeader = acceptHeader;
            return this;
        }
        public HttpRequestBuilder AddUserAgentHeader(string userAgentHeader)
        {
            this.userAgent = userAgentHeader;
            return this;
        }

        public HttpRequestBuilder AddTimeout(TimeSpan timeout)
        {
            this.timeout = timeout;
            return this;
        }

        public HttpRequestBuilder AddAllowAutoRedirect(bool allowAutoRedirect)
        {
            this.allowAutoRedirect = allowAutoRedirect;
            return this;
        }

        public async Task<HttpResponseMessage> SendAsync()
        {
            // Check required arguments
            EnsureArguments();

            UriBuilder builder = new UriBuilder(this.requestUri);
            builder.Query = "name='abc'&password='cde'";

            // Set up request
            var request = new HttpRequestMessage
            {
                Method = this.method,
                RequestUri = new Uri(this.requestUri)
            };

            if (this.content != null)
                request.Content = this.content;

            if (!string.IsNullOrEmpty(this.bearerToken))
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", this.bearerToken);

            request.Headers.Accept.Clear();
            if (!string.IsNullOrEmpty(this.acceptHeader))
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(this.acceptHeader));

            if (!string.IsNullOrEmpty(this.userAgent))
                request.Headers.UserAgent.Add( new ProductInfoHeaderValue (this.userAgent) );

            // Setup client
            var handler = new HttpClientHandler();
            handler.AllowAutoRedirect = this.allowAutoRedirect;

            var client = new System.Net.Http.HttpClient(handler);
            client.Timeout = this.timeout;
            
            return await client.SendAsync(request);
        }

        #region " Private "

        private void EnsureArguments()
        {
            if (this.method == null)
                throw new ArgumentNullException("Method");
            
            if (string.IsNullOrEmpty(this.requestUri))
                throw new ArgumentNullException("Request Uri");
        }

        #endregion
    }
}
