using System;
using System.Threading;
namespace DodgeGame
{
	public class Game
	{

		public static Game instance;

		public Game()
		{
			playerUnit = new PlayerUnit(0, Console.WindowHeight - 4, "P");
			instance = this;

		}

		private Unit playerUnit;
		AIManager AI = new AIManager();
		public bool gameOver = false;

		public void Run()
		{
			
			while (!gameOver)
			{
				
				playerUnit.Update();
				AI.Update();
				playerUnit.Draw();

				Console.SetCursorPosition(0, Console.WindowHeight - 1);
				Console.WriteLine("X: {0} || Y: {1}", playerUnit.X, playerUnit.Y);
				Console.WriteLine(AIManager.EnemyList.Count);
				Console.Write(gameOver);
				//Console.WriteLine("X: {0} || Y: {1}", e.X, e.Y);

				Thread.Sleep(25);
			}
			 


		}



	}
}

