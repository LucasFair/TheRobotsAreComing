
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRobotsAreComing.Model;

namespace TheRobotsAreComing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			RobotSoap robotSoap = new RobotSoap();
            Console.WriteLine(robotSoap.SoapDispenserCapacity);
        }
	}
}
