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
			Console.CursorVisible = false;
			/*while (RunGame())
			{
				
			}*/

			RunGame();

			Console.ResetColor();
			Console.Clear();

			//	SET the position of the cursor to the
			//	right place.
			Console.SetCursorPosition(0, Console.WindowHeight);
		}

		static void RunGame()
		{
			

			Game game = new Game();
			game.Run();

		}
	}
}
