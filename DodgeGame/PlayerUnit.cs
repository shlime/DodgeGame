using System;

namespace DodgeGame
{
	public class PlayerUnit : Unit
	{
		public PlayerUnit(int x, int y, string UnitGraphic) : base(x,y,UnitGraphic)
		{
			
		}

		override public void Update()
		{
			

			if (Console.KeyAvailable == true)
			{

				ConsoleKeyInfo getKey = Console.ReadKey(true);
				switch (getKey.Key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W:
						Y = Y - 1;
						break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S:
						Y = Y + 1;
						break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D:
						X = X+1;
						break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A:
						X = X-1;
						break;
				}
			}


			base.Update();
		}
	}
}

