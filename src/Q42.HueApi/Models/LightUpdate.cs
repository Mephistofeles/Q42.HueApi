using System.Runtime.Serialization;

namespace Q42.HueApi.Models
{
  [DataContract]
  public class LightConfigUpdate
  {
    [DataMember(Name = "startup")]
    public LightStartup Startup { get; set; }

  }
}
