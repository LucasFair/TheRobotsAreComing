using System;

namespace TheRobotsAreComing.Model
{
	internal class RobotSoap
	{
		/// <summary>
		/// Class <c>RobotSoap</c> contains data about robot soap capacity.
		/// </summary>
		private float _soapDispenserCapacity; //  Max Capacity is 2.3 liters
		private const byte SCALE_TO_CENTILITER = 100;
		public float SoapDispenserCapacity
		{
			get { return _soapDispenserCapacity; }
			set { _soapDispenserCapacity = value; }
		}

		public RobotSoap()
		{
			SoapDispenserCapacity = 230f / SCALE_TO_CENTILITER;
		}
	}
}
