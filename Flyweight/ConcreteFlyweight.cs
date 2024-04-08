using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	public class Terrorist : IPlayer
	{
		// Intrinsic Attribute
		private readonly string task;

		// Extrinsic Attribute
		private string weapon;

		public Terrorist()
		{
			task = "PLANT A BOMB";
		}
		public void AssignWeapon(string weapon)
		{
			// Assign a weapon
			this.weapon = weapon;
		}
		public void Mission()
		{
			// Work on the Mission
			Console.WriteLine($"Terrorist with weapon {weapon} | Task is {task}");
		}
	}

	// CounterTerrorist must have weapon and mission
	public class CounterTerrorist : IPlayer
	{
		// Intrinsic Attribute
		private readonly string task;

		// Extrinsic Attribute
		private string weapon;

		public CounterTerrorist()
		{
			task = "DIFFUSE BOMB";
		}
		public void AssignWeapon(string weapon)
		{
			this.weapon = weapon;
		}
		public void Mission()
		{
			Console.WriteLine($"Counter Terrorist with weapon {weapon} | Task is {task}");
		}
	}
}
