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
    public interface IMappings
    {
        /// <summary>
        /// Get mappings. Retrieves a list of mappings. 
        /// </summary>
        /// <param name="filter">Filter as JSON object.</param>
        /// <param name="size">The maximum number of elements in a page.</param>
        /// <param name="page">The (0-based) index of page.</param>
        /// <param name="sort">The order of returned elements. Multiple fields could be used separated by commas (e.g. &#39;&#39;field1,field2&#39;&#39;). Descending order could be requested by appending &#39;&#39;,desc&#39;&#39; at the end of parameter.(e.g. &#39;&#39;field1,field2,desc&#39;&#39;)&#39; </param>
        /// <returns>PagedMapping</returns>
        PagedMapping DataPointMappingsGet (string filter, int? size, int? page, string sort);
        
        /// <summary>
        /// Delete a mapping Deletes a mapping.   
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void DataPointMappingsIdDelete (string id);
        
        /// <summary>
        /// Get a mapping by id Gets a mapping by given id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Mapping</returns>
        Mapping DataPointMappingsIdGet (string id);
        
        /// <summary>
        /// Create single mapping Creates a single mapping. 
        /// </summary>
        /// <param name="mapping"></param>
        /// <returns>Mapping</returns>
        Mapping DataPointMappingsPost (Mapping mapping);
    }
  
}
