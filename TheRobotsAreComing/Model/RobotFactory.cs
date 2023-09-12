using System;

namespace TheRobotsAreComing.Model
{
	/// <summary>
	/// Class <c>RobotFactor</c> is the model of the robots that will be created.
	/// </summary>
	public class RobotFactory
	{
		private bool _roboIsBig;
		private bool _roboHasWireless;
		private bool _roboHasWheels;
		private bool _roboIsBatteryDriven;
		private bool _roboHasSoapDispenser;
		private byte _roboChipType; // 0 - Default, 1 - RX54667, 2 - QT8339
		private ConsoleColor _roboColor = ConsoleColor.White;  // Default color is white

		public bool RoboIsBig
		{
			get { return _roboIsBig; }
			set { _roboIsBig = value; }
		}
		public bool RoboHasWireless
		{
			get { return _roboHasWireless; }
			set { _roboHasWireless = value; }
		}
		public bool RoboHasWheels
		{
			get { return _roboHasWheels; }
			set { _roboHasWheels = value; }
		}
		public bool RoboIsBatteryDriven
		{
			get { return _roboIsBatteryDriven; }
			set { _roboIsBatteryDriven = value; }
		}
		public bool RoboHasSoapDispenser
		{
			get { return _roboHasSoapDispenser; }
			set { _roboIsBatteryDriven = value; }
		}
		public byte RoboChipType
		{
			get { return _roboChipType; }
			set { _roboChipType = value; }
		}
	
		public ConsoleColor RoboColor
		{
			get { return _roboColor; }
			set { _roboColor = value; }
		}


		public RobotFactory()
		{
			_roboColor = ConsoleColor.White;
			_roboIsBig = false;
			_roboHasWireless = false;
			_roboHasWheels = false;
			_roboIsBatteryDriven = false;
			_roboHasSoapDispenser = false;
			_roboChipType = 0;
		}

		public RobotFactory(ConsoleColor roboColor) : this()
		{
			_roboColor = roboColor;
		}
		public RobotFactory(ConsoleColor roboColor, bool roboIsBig) : this(roboColor)
		{
			_roboIsBig = roboIsBig;
		}
		public RobotFactory(ConsoleColor roboColor, bool roboIsBig, bool roboHasWireless) : this(roboColor, roboIsBig)
		{
			_roboHasWireless = roboHasWireless;
		}
		public RobotFactory(ConsoleColor roboColor, bool roboIsBig, bool roboHasWireless,
			bool roboHasWheels) : this(roboColor, roboIsBig, roboHasWireless)
		{
			_roboHasWheels = roboHasWheels;
		}
		public RobotFactory(ConsoleColor roboColor, bool roboIsBig, bool roboHasWireless, bool roboHasWheels,
				bool roboIsBatteryDriven) : this(roboColor, roboIsBig, roboHasWireless, roboHasWheels)
		{
			_roboIsBatteryDriven = roboIsBatteryDriven;
		}
		public RobotFactory(ConsoleColor roboColor, bool roboIsBig, bool roboHasWireless, bool roboHasWheels,
				bool roboIsBatteryDriven, bool roboHasSoapDispenser) : this(roboColor, roboIsBig, roboHasWireless, roboHasWheels, roboIsBatteryDriven)
		{
			_roboHasSoapDispenser = roboHasSoapDispenser;
		}
		public RobotFactory(ConsoleColor roboColor, bool roboIsBig, bool roboHasWireless, bool roboHasWheels,
				bool roboIsBatteryDriven, bool roboHasSoapDispenser, byte roboChipType) : this(roboColor, roboIsBig, 
					roboHasWireless, roboHasWheels, roboIsBatteryDriven, roboHasSoapDispenser)
		{
			_roboChipType = roboChipType;
		}

	}
}
