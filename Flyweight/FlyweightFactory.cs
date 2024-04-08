using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	public class PlayerFactory
	{
		/* Dictionary stores the reference to the object
		of Terrorist(TS) or CounterTerrorist(CT). */
		private static Dictionary<string, IPlayer> players = new Dictionary<string, IPlayer>();

		// Method to get a player
		public static IPlayer GetPlayer(string type)
		{
			IPlayer player = null;

			/* If an object for TS or CT has already been
			created simply return its reference */
			if (players.ContainsKey(type))
				player = players[type];
			else
			{
				/* create an object of TS/CT */
				switch (type)
				{
					case "Terrorist":
						Console.WriteLine("Terrorist Created");
						player = new Terrorist();
						break;
					case "CounterTerrorist":
						Console.WriteLine("Counter Terrorist Created");
						player = new CounterTerrorist();
						break;
					default:
						Console.WriteLine("Unreachable code!");
						break;
				}

				// Once created insert it into the Dictionary
				players.Add(type, player);
			}
			return player;
		}
	}
}
