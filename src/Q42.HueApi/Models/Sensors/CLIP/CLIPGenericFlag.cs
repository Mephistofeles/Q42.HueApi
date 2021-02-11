namespace Q42.HueApi.Models.Sensors.CLIP
{
	public interface CLIPGenericFlag : GeneralSensor
	{
	}

	public interface CLIPGenericFlagConfig : GeneralSensorConfig
	{
	}

	public interface CLIPGenericFlagState : GeneralSensorState
	{
		bool? Flag { get; set; }
	}
}