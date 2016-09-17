using System;
using System.Threading;
namespace DodgeGame
{
	public class Game
	{
		Unit playerUnit = new Unit(1, 1, "::||::");

		public bool Restart = false;

		public void Run()
		{
			playerUnit.Draw();
		}

		public bool Update()
		{
			
			ConsoleKeyInfo getKey = Console.ReadKey();

			switch (getKey.Key)
			{
				case ConsoleKey.UpArrow:
					playerUnit.moveTo(playerUnit.X,playerUnit.Y - 1);
					break;
				case ConsoleKey.DownArrow:
					playerUnit.moveTo(playerUnit.X, playerUnit.Y + 1);
					break;
				case ConsoleKey.RightArrow:
					playerUnit.moveTo(playerUnit.X + 1, playerUnit.Y);
					break;
				case ConsoleKey.LeftArrow:
					playerUnit.moveTo(playerUnit.X - 1, playerUnit.Y);
					break;	
			}

			return true;
		}

	}
}

