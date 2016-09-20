using System;
using System.Threading;
namespace DodgeGame
{
	public class Unit
	{
		public int X
		{
			get { return _x; } 
			set{
				UnDraw();
				_x = value;

			}
		}
		public int Y
		{	
			get { return _y; }
			set
			{
				UnDraw();
				_y = value;
			}
		}

		private int _x;
		private int _y;
		public string UnitGraphic
		{
			get;
			set;
		}
		private string _unitGraphic;

		public Unit()
		{
		}


		public Unit( int x, int y, string UnitGraphic = "@")
		{
			X = x;
			Y = y;
			this.UnitGraphic = UnitGraphic;
			_unitGraphic = UnitGraphic;
		}

		virtual public void Update()
		{

		}

		public void Draw()
		{
			
			Console.SetCursorPosition(this.X, this.Y);
			Console.Write(this.UnitGraphic);
		}

		public void UnDraw()
		{
			Console.SetCursorPosition(this.X, this.Y);
			Console.Write( ' ' );	
		}

	}
}

