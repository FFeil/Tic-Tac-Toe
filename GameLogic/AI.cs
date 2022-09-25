using System;

namespace TicTacToe.GameLogic
{
	public class AI
	{
		private TicTacToeGame t;

		public AI(TicTacToeGame t)
		{
			this.t = t;
		}

		public int[] ChooseCoord()
		{
			int[] result = new int[2];

			if (t.MoveCount == 0)
			{
				result[0] = 1;
				result[1] = 1;
			}
			else if (t.MoveCount == 1 && t.Board[1, 1] == "")
			{
				result[0] = 1;
				result[1] = 1;
			}
			else if (t.MoveCount == 1 && t.Board[0, 0] == "")
			{
				result[0] = 0;
				result[1] = 0;
			}
			else if (t.TwoTogether(t.Next)[0] != -1 && t.MoveCount < 9)
			{
				int randomNumber = new Random().Next(0, 100);
				if (randomNumber > 5)
				{
					result = t.TwoTogether(t.Next);
				}
				else
				{
					result = t.FindRandom();
				}
			}
			else
			{
				result = t.FindRandom();
			}
			return result;
		}
	}
}
