using System;
using System.Collections;

namespace TicTacToe.GameLogic
{
    public class TicTacToeGame
    {
        private string player1, player2;
        public string[,] Board { get; }
        public string Curr { get; private set; }
        public string Next { get; private set; }
        public int MoveCount { get; private set; }

        public TicTacToeGame(string player1, string player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            Next = player1;
            Curr = player2;

            Board = new string[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Board[i, j] = "";
                }
            }
        }

        public bool UpdateBoard(int x, int y)
        {
            if (Board[x, y] == "")
            {
                Board[x, y] = Next;
                SwitchNext();
                MoveCount++;
                return true;
            }
            return false;
        }

        private void SwitchNext()
        {
            if (Next == player1)
            {
                Next = player2;
                Curr = player1;
            }
            else
            {
                Next = player1;
                Curr = player2;
            }
        }

        public bool CheckWin()
        {
            if (Board[0, 0] == Curr && Board[1, 1] == Curr && Board[2, 2] == Curr)
            {
                return true;
            }
            else if (Board[2, 0] == Curr && Board[1, 1] == Curr && Board[0, 2] == Curr)
            {
                return true;
            }

            for (int i = 0; i < 3; i++)
            {
                if (Board[i, 0] == Curr && Board[i, 1] == Curr && Board[i, 2] == Curr)
                {
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (Board[0, i] == Curr && Board[1, i] == Curr && Board[2, i] == Curr)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckFull()
        {
            foreach (string s in Board)
            {
                if (s == "")
                {
                    return false;
                }
            }
            return true;
        }

        public int[] TwoTogether(string playerSymbol)
        {
            string currentSymbol = "";
            int[] result = { -1, -1 };

            for (int i = 0; i < 3; i++)
            {
                if (IsRowAvailable(i))
                {
                    for (int j = 0; j < 3; j += 2)
                    {
                        if (Board[i, j] != "" && Board[i, j] == Board[i, 1])
                        {
                            if (currentSymbol != playerSymbol)
                            {
                                currentSymbol = Board[i, j];
                                result[0] = i;
                                result[1] = 2;
                                if (j == 2)
                                {
                                    result[1] = 0;
                                }
                            }
                        }
                    }
                    if (Board[i, 0] != "" && currentSymbol != playerSymbol && Board[i, 0] == Board[i, 2])
                    {
                        currentSymbol = Board[i, 0];
                        result[0] = i;
                        result[1] = 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (IsColumnAvailable(i))
                {
                    for (int j = 0; j < 3; j += 2)
                    {
                        if (Board[j, i] != "" && Board[j, i] == Board[1, i])
                        {
                            if (currentSymbol != playerSymbol)
                            {
                                currentSymbol = Board[j, i];
                                result[0] = 2;
                                result[1] = i;
                                if (j == 2)
                                {
                                    result[0] = 0;
                                }
                            }
                        }
                    }
                    if (Board[0, i] != "" && currentSymbol != playerSymbol && Board[0, i] == Board[2, i])
                    {
                        currentSymbol = Board[0, i];
                        result[0] = 1;
                        result[1] = i;
                    }
                }
            }

            if (IsDiagonalAvailable(0))
            {
                for (int i = 0; i < 3; i += 2)
                {
                    if (Board[i, i] != "" && Board[i, i] == Board[1, 1])
                    {
                        if (currentSymbol != playerSymbol)
                        {
                            currentSymbol = Board[i, i];
                            result[0] = 2;
                            result[1] = 2;
                            if (i == 2)
                            {
                                result[0] = 0;
                                result[1] = 0;
                            }
                        }
                    }
                }
                if (Board[0, 0] != "" && currentSymbol != playerSymbol && Board[0, 0] == Board[2, 2])
                {
                    currentSymbol = Board[0, 0];
                    result[0] = 1;
                    result[1] = 1;
                }
            }

            if (IsDiagonalAvailable(1))
            {
                if (Board[2, 0] != "" && Board[2, 0] == Board[1, 1])
                {
                    if (currentSymbol != playerSymbol)
                    {
                        currentSymbol = Board[2, 0];
                        result[0] = 0;
                        result[1] = 2;
                    }

                }
                else if (Board[0, 2] != "" && Board[0, 2] == Board[1, 1])
                {
                    if (currentSymbol != playerSymbol)
                    {
                        currentSymbol = Board[0, 2];
                        result[0] = 2;
                        result[1] = 0;
                    }
                }
                if (Board[0, 2] != "" && currentSymbol != playerSymbol && Board[0, 2] == Board[2, 0])
                {
                    currentSymbol = Board[0, 2];
                    result[0] = 1;
                    result[1] = 1;
                }
            }

            return result;
        }

        private bool IsRowAvailable(int row)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Board[row, i] == "")
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsColumnAvailable(int column)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Board[i, column] == "")
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsDiagonalAvailable(int diag)
        {
            if (diag == 0) // Top left -> bottom right
            {
                for (int i = 0; i < 3; i++)
                {
                    if (Board[i, i] == "")
                    {
                        return true;
                    }
                }
            }

            if (diag == 1) // Top right -> bottom left
            {
                if (Board[0, 2] == "" || Board[1, 1] == "" || Board[2, 0] == "")
                {
                    return true;
                }

            }

            return false;
        }

        public int[] FindRandom()
        {
            int[] result = { -1, -1 };
            int counter = 0;
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Board[i, j] == "")
                    {
                        x.Add(i);
                        y.Add(j);
                        counter++;
                    }
                }
            }
            if (counter > 0)
            {
                int randomNumber = new Random().Next(0, counter);
                result[0] = (int)x[randomNumber];
                result[1] = (int)y[randomNumber];
            }

            return result;
        }
    }
}
