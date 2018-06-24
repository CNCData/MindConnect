
using HttpClient;
using MindConnect.Client;
using MindConnect.Model;
using RestSharp;
using System;
using System.Collections.Generic;

namespace MindConnect
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Mappings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        public Mappings(String basePath = "https://localhost/api/mindconnect/v3")
        {
            BasePath = basePath;
        }

        /// <summary>
        /// Gets or sets the base path.
        /// </summary>
        /// <value>The base path</value>
        public string BasePath { get; set; }

        /// <summary>
        /// Get mappings. Retrieves a list of mappings. 
        /// </summary>
        /// <param name="filter">Filter as JSON object.</param>
        /// <param name="size">The maximum number of elements in a page.</param>
        /// <param name="page">The (0-based) index of page.</param>
        /// <param name="sort">The order of returned elements. Multiple fields could be used separated by commas (e.g. &#39;&#39;field1,field2&#39;&#39;). Descending order could be requested by appending &#39;&#39;,desc&#39;&#39; at the end of parameter.(e.g. &#39;&#39;field1,field2,desc&#39;&#39;)&#39; </param>
        /// <returns>PagedMapping</returns>
        public PagedMapping DataPointMappingsGet(string filter, int? size, int? page, string sort)
        {
            const string endpoint = "/dataPointMappings";
            string requestUri = $"{BasePath}{endpoint}";

            var queryParams = new Dictionary<String, String>();
            if (filter != null) queryParams.Add("filter", Helpers.ParameterToString(filter)); // query parameter
            if (size != null) queryParams.Add("size", Helpers.ParameterToString(size)); // query parameter
            if (page != null) queryParams.Add("page", Helpers.ParameterToString(page)); // query parameter
            if (sort != null) queryParams.Add("sort", Helpers.ParameterToString(sort)); // query parameter

            var response = HttpRequestFactory.Get(requestUri, Helpers.DictionaryToUriQueryString(queryParams) ).Result;

            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling DataPointMappingsGet: " + response.Content, response.Content);
            }
            else if (((int)response.StatusCode) == 0)
            {
                throw new ApiException((int)response.StatusCode, "Error calling DataPointMappingsGet: " + response.ReasonPhrase, response.ReasonPhrase);
            }
            return response.ContentAsType<PagedMapping>(); 
        }

        /// <summary>
        /// Delete a mapping Deletes a mapping.   
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void DataPointMappingsIdDelete(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DataPointMappingsIdDelete");

            const string endpoint = "/dataPointMappings/{id}";
            string requestUri = $"{this.BasePath}{endpoint}";

            var response = HttpRequestFactory.Delete(requestUri).Result;

            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling DataPointMappingsIdDelete: " + response.Content, response.Content);
            }
            else if (((int)response.StatusCode) == 0)
            {
                throw new ApiException((int)response.StatusCode, "Error calling DataPointMappingsIdDelete: " + response.ReasonPhrase, response.ReasonPhrase);
            }
            return;
        }

        /// <summary>
        /// Get a mapping by id Gets a mapping by given id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Mapping</returns>
        public Mapping DataPointMappingsIdGet(string id)
        {
            const string endpoint = "/dataPointMappings/{id}";
            string requestUri = $"{this.BasePath}{endpoint}";

            var response = HttpRequestFactory.Get(requestUri).Result;

            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling DataPointMappingsIdDelete: " + response.Content, response.Content);
            }
            else if (((int)response.StatusCode) == 0)
            {
                throw new ApiException((int)response.StatusCode, "Error calling DataPointMappingsIdDelete: " + response.ReasonPhrase, response.ReasonPhrase);
            }
            
            return response.ContentAsType<Mapping>(); 
        }

        /// <summary>
        /// Create single mapping Creates a single mapping. 
        /// </summary>
        /// <param name="mapping"></param>
        /// <returns>Mapping</returns>
        public Mapping DataPointMappingsPost(Mapping mapping)
        {
            const string endpoint = "/dataPointMappings";
            string requestUri = $"{this.BasePath}{endpoint}";

            var response = HttpRequestFactory.Post(requestUri, mapping).Result;

            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling DataPointMappingsIdDelete: " + response.Content, response.Content);
            }
            else if (((int)response.StatusCode) == 0)
            {
                throw new ApiException((int)response.StatusCode, "Error calling DataPointMappingsIdDelete: " + response.ReasonPhrase, response.ReasonPhrase);
            }
            
            return response.ContentAsType<Mapping>(); 
        }
    }

}
