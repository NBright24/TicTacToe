using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int turn = 1;
        int click1 = 0, click2 = 0, click3 = 0, click4 = 0, click5 = 0, click6 = 0, click7 = 0, click8 = 0, click9 = 0;

        private void Tile4_Click(object sender, EventArgs e)
        {
            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    Tile4.Text = "X";
                    click4++;
                }
                else
                {
                    Tile4.Text = "O";
                    click4++;
                }
                turn++;
            }
            else
            {
                Tile4.Text = Tile4.Text;
            }
            display();
            checkit();
        }

        private void Tile5_Click(object sender, EventArgs e)
        {
            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    Tile5.Text = "X";
                    click5++;
                }
                else
                {
                    Tile5.Text = "O";
                    click5++;
                }
                turn++;
            }
            else
            {
                Tile5.Text = Tile5.Text;
            }
            display();
            checkit();
        }

        private void Tile6_Click(object sender, EventArgs e)
        {
            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    Tile6.Text = "X";
                    click6++;
                }
                else
                {
                    Tile6.Text = "O";
                    click6++;
                }
                turn++;
            }
            else
            {
                Tile6.Text = Tile6.Text;
            }
            display();
            checkit();
        }

        private void Tile7_Click(object sender, EventArgs e)
        {
            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    Tile7.Text = "X";
                    click7++;
                }
                else
                {
                    Tile7.Text = "O";
                    click7++;
                }
                turn++;
            }
            else
            {
                Tile7.Text = Tile7.Text;
            }
            display();
            checkit();
        }

        private void Tile8_Click(object sender, EventArgs e)
        {
            if (click8 == 0)
            {
                if (turn % 2 != 0)
                {
                    Tile8.Text = "X";
                    click8++;
                }
                else
                {
                    Tile8.Text = "O";
                    click8++;
                }
                turn++;
            }
            else
            {
                Tile8.Text = Tile8.Text;
            }
            display();
            checkit();
        }

        private void Tile9_Click(object sender, EventArgs e)
        {
            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    Tile9.Text = "X";
                    click9++;
                }
                else
                {
                    Tile9.Text = "O";
                    click9++;
                }
                turn++;
            }
            else
            {
                Tile9.Text = Tile9.Text;
            }
            display();
            checkit();
        }

        private void Tile3_Click(object sender, EventArgs e)
        {
            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    Tile3.Text = "X";
                    click3++;
                }
                else
                {
                    Tile3.Text = "O";
                    click3++;
                }
                turn++;
            }
            else
            {
                Tile3.Text = Tile3.Text;
            }
            display();
            checkit();
        }

        private void Tile2_Click(object sender, EventArgs e)
        {
            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    Tile2.Text = "X";
                    click2++;
                }
                else
                {
                    Tile2.Text = "O";
                    click2++;
                }
                turn++;
            }
            else
            {
                Tile2.Text = Tile2.Text;
            }
            display();
            checkit();
        }
        private void Tile1_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    Tile1.Text = "X";
                    click1++;
                }
                else
                {
                    Tile1.Text = "O";
                    click1++;
                }
                turn++;
            }
            else
            {
                Tile1.Text = Tile1.Text;
            }
            display();
            checkit();
        }


        private void TurnDisplay_Click(object sender, EventArgs e)
        {

        }
        int player1 = 0, player2 = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void display()
        {
            if (turn % 2 != 0)
            {
                TurnDisplay.Text = "Player X";
            }
            else
            {
                TurnDisplay.Text = "Player O";
            }
        }
        public void checkit()
        {

        }
    }
}
