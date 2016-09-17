using System;
using System.Threading;

namespace DodgeGame
{
	class GameMain
	{
		static void Main()
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.Black;
			while (RunGame())
			{

			}

			Console.ResetColor();
			Console.Clear();

			//	SET the position of the cursor to the
			//	right place.
			Console.SetCursorPosition(0, Console.WindowHeight);
		}

		static bool RunGame()
		{
			Console.CursorVisible = false;

			Game game = new Game();
			game.Run();

			while (game.Update())
			{
				Thread.Sleep(10);
			}
			return game.Restart;
		}
	}
}
