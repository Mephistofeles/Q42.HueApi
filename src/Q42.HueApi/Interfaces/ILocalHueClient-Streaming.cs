using Q42.HueApi.Models.Groups;
using System.Threading.Tasks;

namespace Q42.HueApi.Interfaces
{
  /// <summary>
  /// Hue Client for interaction with a local bridge
  /// </summary>
  public interface ILocalHueClient_Streaming
  {
    /// <summary>
    /// Enable or disable streaming api on a group
    /// </summary>
    /// <param name="id"></param>
    /// <param name="active"></param>
    /// <returns></returns>
    Task<HueResults> SetStreamingAsync(string id, bool active = true);



  }
}
