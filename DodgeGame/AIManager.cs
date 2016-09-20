using System;
using System.Timers;
using System.Collections.Generic;
namespace DodgeGame
{
	public class AIManager
	{
		static Timer timer = new Timer(1000);
		static int i = 2;
		static Random random = new Random();
		public static List<EnemyUnit> EnemyList = new List<EnemyUnit>();

		public AIManager()
		{
			timer.AutoReset = true;
			timer.Elapsed += AIA;
			timer.Start();
		}

		public void Update()
		{
			if (i <= 0)
			{
				i = 1;
				EnemyUnit _e = new EnemyUnit(random.Next(0, Console.WindowWidth - 1), 0, "O");
				EnemyList.Add(_e);

			}

		}

		public void AIA(object sender, ElapsedEventArgs e)
		{

			i--;
			GC.Collect();
		}

	}
}

