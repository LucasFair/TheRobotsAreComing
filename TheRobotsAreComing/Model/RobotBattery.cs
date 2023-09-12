using System;

namespace TheRobotsAreComing.Model
{
	/// <summary>
	/// Class <c>RobotBattery</c> contains the data for the robot's battery.
	/// </summary>
	internal class RobotBattery
	{
		private byte _batteryCapacity; // Capacity is 0 - 255 

		public byte BatteryCapacity
		{
			get { return _batteryCapacity; }
			set { _batteryCapacity = value; }
		}

		public RobotBattery()
		{
			BatteryCapacity = 255;
		}
	}
}
