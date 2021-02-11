namespace Q42.HueApi.Models.Sensors.CLIP
{
	public interface CLIPOpenClose : GeneralSensor
	{
	}

	public interface CLIPOpenCloseConfig : GeneralSensorConfig
	{
	}

	public interface CLIPOpenCloseState : GeneralSensorState
	{
		bool? Open { get; set; }
	}
}
