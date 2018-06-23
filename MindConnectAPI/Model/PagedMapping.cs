using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MindConnect.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PagedMapping {
    /// <summary>
    /// Gets or Sets Content
    /// </summary>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public List<Mapping> Content { get; set; }

    /// <summary>
    /// Whether the current item is the last one.
    /// </summary>
    /// <value>Whether the current item is the last one.</value>
    [DataMember(Name="last", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last")]
    public bool? Last { get; set; }

    /// <summary>
    /// The number of total pages.
    /// </summary>
    /// <value>The number of total pages.</value>
    [DataMember(Name="totalPages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalPages")]
    public int? TotalPages { get; set; }

    /// <summary>
    /// The total amount of elements.
    /// </summary>
    /// <value>The total amount of elements.</value>
    [DataMember(Name="totalElements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalElements")]
    public int? TotalElements { get; set; }

    /// <summary>
    /// The number of elements currently on this page.
    /// </summary>
    /// <value>The number of elements currently on this page.</value>
    [DataMember(Name="numberOfElements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfElements")]
    public int? NumberOfElements { get; set; }

    /// <summary>
    /// Whether the current item is the first one.
    /// </summary>
    /// <value>Whether the current item is the first one.</value>
    [DataMember(Name="first", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first")]
    public bool? First { get; set; }

    /// <summary>
    /// The sorting parameters for the page.
    /// </summary>
    /// <value>The sorting parameters for the page.</value>
    [DataMember(Name="sort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort")]
    public List<Order> Sort { get; set; }

    /// <summary>
    /// The size of the page.
    /// </summary>
    /// <value>The size of the page.</value>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public int? Size { get; set; }

    /// <summary>
    /// The number of the current item.
    /// </summary>
    /// <value>The number of the current item.</value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public int? Number { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PagedMapping {\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  Last: ").Append(Last).Append("\n");
      sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
      sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
      sb.Append("  NumberOfElements: ").Append(NumberOfElements).Append("\n");
      sb.Append("  First: ").Append(First).Append("\n");
      sb.Append("  Sort: ").Append(Sort).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
