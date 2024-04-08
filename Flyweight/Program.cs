using System;
using System.Collections.Generic;

namespace Flyweight
{
	
	public class CounterStrike
	{
		// All player types and weapon (used by GetRandPlayerType()
		// and GetRandWeapon())
		private static string[] playerTypes = { "Terrorist", "CounterTerrorist" };
		private static string[] weapons = { "AK-47", "Maverick", "Gut Knife", "Desert Eagle" };

		// Driver code
		public static void Main(string[] args)
		{
			/* Assume that we have a total of 10 players
			in the game. */
			for (int i = 0; i < 10; i++)
			{
				/* getPlayer() is called simply using the class
				name since the method is a static one */
				IPlayer player = PlayerFactory.GetPlayer(GetRandPlayerType());

				/* Assign a weapon chosen randomly uniformly
				from the weapon array */
				player.AssignWeapon(GetRandWeapon());

				// Send this player on a mission
				player.Mission();
			}
		}

		// Utility methods to get a random player type and
		// weapon
		public static string GetRandPlayerType()
		{
			Random r = new Random();

			// Will return an integer between [0,2)
			int randInt = r.Next(playerTypes.Length);

			// return the player stored at index 'randInt'
			return playerTypes[randInt];
		}
		public static string GetRandWeapon()
		{
			Random r = new Random();

			// Will return an integer between [0,5)
			int randInt = r.Next(weapons.Length);

			// Return the weapon stored at index 'randInt'
			return weapons[randInt];
		}
	}
}