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
  public class Mapping {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets AgentId
    /// </summary>
    [DataMember(Name="agentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agentId")]
    public Guid? AgentId { get; set; }

    /// <summary>
    /// Gets or Sets DataPointId
    /// </summary>
    [DataMember(Name="dataPointId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataPointId")]
    public string DataPointId { get; set; }

    /// <summary>
    /// Gets or Sets DataPointUnit
    /// </summary>
    [DataMember(Name="dataPointUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataPointUnit")]
    public string DataPointUnit { get; set; }

    /// <summary>
    /// Gets or Sets DataPointType
    /// </summary>
    [DataMember(Name="dataPointType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataPointType")]
    public string DataPointType { get; set; }

    /// <summary>
    /// Gets or Sets EntityId
    /// </summary>
    [DataMember(Name="entityId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entityId")]
    public Guid? EntityId { get; set; }

    /// <summary>
    /// Gets or Sets PropertySetName
    /// </summary>
    [DataMember(Name="propertySetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertySetName")]
    public string PropertySetName { get; set; }

    /// <summary>
    /// Gets or Sets PropertyName
    /// </summary>
    [DataMember(Name="propertyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyName")]
    public string PropertyName { get; set; }

    /// <summary>
    /// Gets or Sets PropertyUnit
    /// </summary>
    [DataMember(Name="propertyUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyUnit")]
    public string PropertyUnit { get; set; }

    /// <summary>
    /// Gets or Sets PropertyType
    /// </summary>
    [DataMember(Name="propertyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyType")]
    public string PropertyType { get; set; }

    /// <summary>
    /// Gets or Sets QualityEnabled
    /// </summary>
    [DataMember(Name="qualityEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qualityEnabled")]
    public bool? QualityEnabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Mapping {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  AgentId: ").Append(AgentId).Append("\n");
      sb.Append("  DataPointId: ").Append(DataPointId).Append("\n");
      sb.Append("  DataPointUnit: ").Append(DataPointUnit).Append("\n");
      sb.Append("  DataPointType: ").Append(DataPointType).Append("\n");
      sb.Append("  EntityId: ").Append(EntityId).Append("\n");
      sb.Append("  PropertySetName: ").Append(PropertySetName).Append("\n");
      sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
      sb.Append("  PropertyUnit: ").Append(PropertyUnit).Append("\n");
      sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
      sb.Append("  QualityEnabled: ").Append(QualityEnabled).Append("\n");
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
