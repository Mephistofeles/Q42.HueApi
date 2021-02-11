namespace Q42.HueApi.Models.Sensors.CLIP
{
	public interface CLIPGenericStatus : GeneralSensor
	{
	}

	public interface CLIPGenericStatusConfig : GeneralSensorConfig
	{
	}

	public interface CLIPGenericStatusState : GeneralSensorState
	{
		int? Status { get; set; }
	}
}
