using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Q42.HueApi.Models.Groups
{
  [DataContract]
  internal class UpdateGroupRequest
  {
    [DataMember(Name = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The IDs of the lights that are in the group.
    /// </summary>
    [DataMember(Name = "lights")]
    public IEnumerable<string> Lights { get; set; }

    /// <summary>
    /// Category of the Room type. Default is "Other".
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    [DataMember(Name = "class")]
    public RoomClass? Class { get; set; }
  }
}
