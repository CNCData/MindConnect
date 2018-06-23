using System;
using System.Collections.Generic;
using RestSharp;
using MindConnect.Client;
using MindConnect.Model;

namespace MindConnect
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExchange
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="userAgent"></param>
        /// <param name="message">Multipart message.</param>
        /// <returns></returns>
        void ExchangePost (string userAgent, byte[] message);
    }

}
