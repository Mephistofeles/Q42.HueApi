namespace Q42.HueApi
{
  /// <summary>
  /// Model for response from http://www.meethue.com/api/nupnp
  /// </summary>
  internal class NuPnPResponse
  {
    public string Id { get; set; }
    public string InternalIpAddress { get; set; }
    public string MacAddress { get; set; }
  }
}
