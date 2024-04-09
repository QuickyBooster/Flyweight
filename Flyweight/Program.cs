namespace Flyweight
{

	public class CounterStrike
	{
		// Danh sách loại player
		// Danh sách loại vũ khí
		private static string[] playerTypes = { "Terrorist", "CounterTerrorist" };
		private static string[] weapons = { "AK-47", "Maverick", "Gut Knife", "Desert Eagle" };

		public static void Main(string[] args)
		{
			/* 10 players 1 map */
			for (int i = 0; i < 10; i++)
			{
				/* Tạo ra player từ PlayerFactor ~ FlyweightFactory */
				IPlayer player = PlayerFactory.GetPlayer(GetRandPlayerType());

				/* Lấy vũ khí cho mỗi player */
				player.AssignWeapon(GetRandWeapon());

				// Cho player thực hiện nhiệm vụ
				player.Mission();
			}
		}

		// Hàm lấy ngẫu nhiên loại player và vũ khí
		public static string GetRandPlayerType()
		{
			Random r = new Random();

			int randInt = r.Next(playerTypes.Length);

			return playerTypes[randInt];
		}
		public static string GetRandWeapon()
		{
			Random r = new Random();

			int randInt = r.Next(weapons.Length);

			return weapons[randInt];
		}
	}
}