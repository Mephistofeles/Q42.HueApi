namespace Q42.HueApi.Models
{
	public class RemoteAuthorizeResponse
	{
		public string Code { get; set; }

		/// <summary>
		/// Roundtrip parameter to validate the response
		/// </summary>
		public string State { get; set; }
	}
}
