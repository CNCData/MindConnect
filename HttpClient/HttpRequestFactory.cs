using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClient
{
    public static class HttpRequestFactory
    {
        public static async Task<HttpResponseMessage> Get(string requestUri)
            => await Get(requestUri, null, string.Empty);

        public static async Task<HttpResponseMessage> Get(string requestUri, Dictionary<String, String> queryParams)
           => await Get(requestUri, queryParams, string.Empty);

        public static async Task<HttpResponseMessage> Get(string requestUri, Dictionary<String, String> queryParams, string bearerToken)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Get)
                                .AddRequestUri(requestUri)
                                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Post(string requestUri, object value)
            => await Post(requestUri, value, string.Empty, string.Empty);

        public static async Task<HttpResponseMessage> Post(string requestUri, object value, string userAgent)
            => await Post(requestUri, value, string.Empty, string.Empty);

        public static async Task<HttpResponseMessage> Post(string requestUri, object value, string userAgent, string bearerToken )
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Post)
                                .AddRequestUri(requestUri)
                                .AddContent(new JsonContent(value))
                                .AddBearerToken(bearerToken)
                                .AddUserAgentHeader(userAgent);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Put(string requestUri, object value)
            => await Put(requestUri, value, string.Empty);

        public static async Task<HttpResponseMessage> Put(string requestUri, object value, string bearerToken)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Put)
                                .AddRequestUri(requestUri)
                                .AddContent(new JsonContent(value))
                                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Patch(string requestUri, object value)
            => await Patch(requestUri, value, string.Empty);

        public static async Task<HttpResponseMessage> Patch(string requestUri, object value, string bearerToken)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(new HttpMethod("PATCH"))
                                .AddRequestUri(requestUri)
                                .AddContent(new PatchContent(value))
                                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Delete(string requestUri)
            => await Delete(requestUri, string.Empty);

        public static async Task<HttpResponseMessage> Delete(string requestUri, string bearerToken)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Delete)
                                .AddRequestUri(requestUri)
                                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> PostFile(string requestUri,string filePath, string apiParamName)
            => await PostFile(requestUri, filePath, apiParamName, string.Empty);

        public static async Task<HttpResponseMessage> PostFile(string requestUri,string filePath, string apiParamName, string bearerToken)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Post)
                                .AddRequestUri(requestUri)
                                .AddContent(new FileContent(filePath, apiParamName))
                                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }
    }
}
