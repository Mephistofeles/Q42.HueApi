using Q42.HueApi.Models;
using System.Threading.Tasks;

namespace Q42.HueApi.Interfaces
{
  public interface IHueClient_Capabilities
  {
    Task<BridgeCapabilities?> GetCapabilitiesAsync();
  }
}
