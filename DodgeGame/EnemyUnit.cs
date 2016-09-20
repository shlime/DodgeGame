using System;

using System.Timers;


namespace DodgeGame
{
	public class EnemyUnit : Unit
	{

		Random random = new Random();
		public EnemyUnit()
		{


		}
		public EnemyUnit(int x, int y, string UnitGraphic) : base(x, y, UnitGraphic)
		{


		}


		override public void Update()
		{
			//	LETS DO AI things HERE.
			if (this.Y >= Console.WindowHeight - 1)
			{
				this.Y = 0;
				this.X = random.Next(0, Console.WindowWidth);
			}

			this.Y++;
		}

	}
}

