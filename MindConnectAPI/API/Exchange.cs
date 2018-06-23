using System;
using System.Collections.Generic;
using RestSharp;
using MindConnect.Client;
using MindConnect.Model;
using HttpClient;

namespace MindConnect
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Exchange : IExchange
    {
        const string baseUri = "http://localhost:56942";
        const string endpoint = "/exchange";
        string requestUri = $"{baseUri}{endpoint}";
        /// <summary>
        ///  
        /// </summary>s
        /// <param name="userAgent"></param>
        /// <param name="message">Multipart message.</param>
        /// <returns></returns>
        public void ExchangePost(string userAgent, byte[] message)
        {
            // verify the required parameter 'userAgent' is set
            if (userAgent == null) throw new ApiException(400, "Missing required parameter 'userAgent' when calling ExchangePost");

            // verify the required parameter 'message' is set
            if (message == null) throw new ApiException(400, "Missing required parameter 'message' when calling ExchangePost");

            // make the HTTP request
            var response = HttpRequestFactory.Post(requestUri, message, userAgent).Result;

            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling ExchangePost: " + response.Content, response.Content);
            }
            else if (((int)response.StatusCode) == 0)
            {
                throw new ApiException((int)response.StatusCode, "Error calling ExchangePost: " + response.ReasonPhrase, response.ReasonPhrase);
            }
            return;
        }
    }
}
