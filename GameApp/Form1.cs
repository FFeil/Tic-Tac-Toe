using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.GameLogic;

namespace TicTacToe.GameApp
{
    public partial class TicTacToeForm : Form
    {
        private TicTacToeGame t;
        private string player1 = "o";
        private string player2 = "b";
        private AI ai;
        private bool aiActive = false;

        private Label[,] labels = new Label[3, 3];

        public TicTacToeForm()
        {
            InitializeComponent();

            labels[0, 0] = label00;
            labels[0, 1] = label01;
            labels[0, 2] = label02;
            labels[1, 0] = label10;
            labels[1, 1] = label11;
            labels[1, 2] = label12;
            labels[2, 0] = label20;
            labels[2, 1] = label21;
            labels[2, 2] = label22;

            ResetBoard();

            t = new TicTacToeGame(player1, player2);
        }

        private void ResetBoard()
        {
            foreach (var l in labels)
            {
                l.Text = " ";
            }
            label1.Text = " ";
            labelSymbol1.Text = " ";
            labelSymbol2.Text = " ";
            labelBot1.Visible = false;
            labelBot2.Visible = false;
            labelWinner1.Visible = false;
            labelWinner2.Visible = false;
        }

        private void DoTurn(int x, int y)
        {
            if (labels[x, y].Text == " ")
            {
                Play(x, y);
                if (aiActive)
                {
                    int[] coord = ai.ChooseCoord();
                    Play(coord[0], coord[1]);
                }
            }
        }

        private void Play(int x, int y)
        {
            string next = t.Next;

            if (!t.CheckWin() && !t.CheckFull() && t.UpdateBoard(x, y))
            {
                labels[x, y].Text = next;
                if (t.CheckWin() || t.CheckFull())
                {
                    label1.Text = "Game Over";

                    if (aiActive)
                    {
                        MessageBox.Show(PopUpWindowMessage1Player(), "Game Over");
                    }
                    else
                    {
                        MessageBox.Show(PopUpWindowMessage2Player(), "Game Over");
                    }

                    aiActive = false;
                }
            }
        }

        private string PopUpWindowMessage1Player()
        {
            if (!t.CheckWin() && t.CheckFull())
            {
                return "It's a draw!";
            }
            else if (t.Curr == player1 && t.CheckWin())
            {
                labelWinner1.Visible = true;

                if (!labelBot1.Visible)
                {
                    return "You win!";
                }
                else
                {
                    return "You loose!"; ;
                }
            }
            else
            {
                labelWinner2.Visible = true;

                if (!labelBot2.Visible)
                {
                    return "You win!";
                }
                else
                {
                    return "You loose!";
                }
            }
        }

        private string PopUpWindowMessage2Player()
        {
            if (!t.CheckWin() && t.CheckFull())
            {
                return "It's a draw!";
            }
            else
            {
                if (t.Curr == player1)
                {
                    labelWinner1.Visible = true;
                    return "Player 1 wins!";
                }
                else
                {
                    labelWinner2.Visible = true;
                    return "Player 2 wins!";
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetBoard();
            labelSymbol1.Text = player1;
            labelSymbol2.Text = player2;
            t = new TicTacToeGame(player1, player2);
            ai = new AI(t);
            Random rand = new Random();

            if (rand.Next(0, 2) == 1)
            {
                labelBot1.Visible = true;
                int[] coord = ai.ChooseCoord();
                Play(coord[0], coord[1]);
            }
            else
            {
                labelBot2.Visible = true;
            }
            aiActive = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aiActive = false;
            ResetBoard();
            labelSymbol1.Text = player1;
            labelSymbol2.Text = player2;
            t = new TicTacToeGame(player1, player2);
        }
        private void label00_Click(object sender, EventArgs e)
        {
            DoTurn(0, 0);
        }

        private void label01_Click(object sender, EventArgs e)
        {
            DoTurn(0, 1);
        }

        private void label02_Click(object sender, EventArgs e)
        {
            DoTurn(0, 2);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            DoTurn(1, 0);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            DoTurn(1, 1);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            DoTurn(1, 2);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            DoTurn(2, 0);
        }

        private void label21_Click(object sender, EventArgs e)
        {
            DoTurn(2, 1);
        }

        private void label22_Click(object sender, EventArgs e)
        {
            DoTurn(2, 2);
        }
    }
}