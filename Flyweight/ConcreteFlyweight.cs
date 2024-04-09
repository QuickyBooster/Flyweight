namespace Flyweight
{
	public class Terrorist : IPlayer
	{
		// Trạng thái nội tại
		private readonly string task;

		// Ngoại tại
		private string weapon;

		public Terrorist()
		{
			task = "PLANT A BOMB";
		}
		public void AssignWeapon(string weapon)
		{
			this.weapon = weapon;
		}
		public void Mission()
		{
			// Tương tác với nội tại
			Console.WriteLine($"Terrorist with weapon {weapon} | Task is {task}");
		}
	}

	public class CounterTerrorist : IPlayer
	{
		private readonly string task;

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
