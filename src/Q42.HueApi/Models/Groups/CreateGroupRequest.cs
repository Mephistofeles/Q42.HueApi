using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Q42.HueApi.Models.Groups
{
  [DataContract]
  internal class CreateGroupRequest : UpdateGroupRequest
  {

    /// <summary>
    /// Luminaire / Lightsource / LightGroup
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    [DataMember(Name = "type")]
    public GroupType Type { get; set; }

  }
}
