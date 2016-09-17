using System;
using System.Threading;
namespace DodgeGame
{
	public class Game
	{

		public Game()
		{
			playerUnit = new PlayerUnit(1, 1, "P");

		}

		private Unit playerUnit;

		public void Run()
		{

			while (true)
			{
				
				playerUnit.Update();
				playerUnit.Draw();
				Thread.Sleep(15);
			}
			 


		}



	}
}

