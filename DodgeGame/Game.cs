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
		public static bool gameOver = false;

		public void Run()
		{

			int maxFPS = 30;
			int deltaTime = 1000 / maxFPS;

			while (!gameOver)
			{
				
				playerUnit.Update();
				AI.Update();
				foreach (Unit unit in AIManager.EnemyList)
				{
					unit.Update();
					unit.Draw();
				}
				playerUnit.Draw();

				Console.SetCursorPosition(0, Console.WindowHeight - 1);
				Console.WriteLine("X: {0} || Y: {1}", playerUnit.X, playerUnit.Y);
				Console.WriteLine("Enemies: " + AIManager.EnemyList.Count);
				Console.Write("Game over variable: " + gameOver);
				//Console.WriteLine("X: {0} || Y: {1}", e.X, e.Y);

				Thread.Sleep(deltaTime);
			}
			Console.WriteLine("GAME OVER");
			Console.Read();


		}



	}
}

