namespace Q42.HueApi.Interfaces
{
  /// <summary>
  /// Hue Client for interaction with the bridge
  /// </summary>
  public interface IHueClient :
    IHueClient_Capabilities,
    IHueClient_Config,
    IHueClient_Groups,
    IHueClient_Lights,
    IHueClient_ResourceLinks,
    IHueClient_Rules,
    IHueClient_Scenes,
    IHueClient_Schedules,
    IHueClient_Sensors
  {
  }
}
