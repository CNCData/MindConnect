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
  public class Order {
    /// <summary>
    /// The order the property shall be sorted for.
    /// </summary>
    /// <value>The order the property shall be sorted for.</value>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    /// <summary>
    /// The property to order for.
    /// </summary>
    /// <value>The property to order for.</value>
    [DataMember(Name="property", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property")]
    public string Property { get; set; }

    /// <summary>
    /// Whether or not the sort will be case sensitive.
    /// </summary>
    /// <value>Whether or not the sort will be case sensitive.</value>
    [DataMember(Name="ignoreCase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// Gets or Sets NullHandling
    /// </summary>
    [DataMember(Name="nullHandling", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nullHandling")]
    public string NullHandling { get; set; }

    /// <summary>
    /// Whether sorting for this property shall be descending.
    /// </summary>
    /// <value>Whether sorting for this property shall be descending.</value>
    [DataMember(Name="descending", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "descending")]
    public bool? Descending { get; set; }

    /// <summary>
    /// Whether sorting for this property shall be ascending.
    /// </summary>
    /// <value>Whether sorting for this property shall be ascending.</value>
    [DataMember(Name="ascending", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ascending")]
    public bool? Ascending { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Order {\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  Property: ").Append(Property).Append("\n");
      sb.Append("  IgnoreCase: ").Append(IgnoreCase).Append("\n");
      sb.Append("  NullHandling: ").Append(NullHandling).Append("\n");
      sb.Append("  Descending: ").Append(Descending).Append("\n");
      sb.Append("  Ascending: ").Append(Ascending).Append("\n");
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
