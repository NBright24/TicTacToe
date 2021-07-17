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

        ushort turn = 1;
        ushort click1 = 0, click2 = 0, click3 = 0, click4 = 0, click5 = 0, click6 = 0, click7 = 0, click8 = 0, click9 = 0;
        ushort playerX = 0, playerO = 0;

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

        private void RestartBTN_Click(object sender, EventArgs e)
        {
            cleargame();
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            DisplayOScore.Text = "0";
            DisplayXScore.Text = "0";
            playerO = 0;
            playerX = 0;
            cleargame();
        }

        private void HelpBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                ("HOW TO PLAY?\n\nPlayer 1 automatically plays as Player X and is assigned with X.\n\nPlayer 2 gets to be Player O and is assigned with O.\n\n" +
                "Whichever icon matches 3 in a row vertically, horizontally, or diagonally wins.\n\nRESET: Resets everything including score.\nRESTART: Clears the board for players to play again.");
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
            if(Tile1.Text != "" && Tile2.Text != "" && Tile3.Text != "")
            {
                if(Tile1.Text == Tile2.Text && Tile1.Text == Tile3.Text)
                {
                    Tile1.BackColor = Color.Green;
                    Tile1.ForeColor = Color.White;
                    Tile2.BackColor = Color.Green;
                    Tile2.ForeColor = Color.White;
                    Tile3.BackColor = Color.Green;
                    Tile3.ForeColor = Color.White;
                    
                    if(Tile1.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!");
                        playerX++;
                        DisplayXScore.Text = playerX.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!");
                        playerO++;
                        DisplayOScore.Text = playerO.ToString();
                    }
                    cleargame();

                }
            }

            if (Tile4.Text != "" && Tile5.Text != "" && Tile6.Text != "")
            {
                if (Tile4.Text == Tile5.Text && Tile4.Text == Tile6.Text)
                {
                    Tile4.BackColor = Color.Green;
                    Tile4.ForeColor = Color.White;
                    Tile5.BackColor = Color.Green;
                    Tile5.ForeColor = Color.White;
                    Tile6.BackColor = Color.Green;
                    Tile6.ForeColor = Color.White;

                    if (Tile4.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!");
                        playerX++;
                        DisplayXScore.Text = playerX.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!");
                        playerO++;
                        DisplayOScore.Text = playerO.ToString();
                    }
                    cleargame();
                }
            }

            if (Tile7.Text != "" && Tile8.Text != "" && Tile9.Text != "")
            {
                if (Tile7.Text == Tile8.Text && Tile7.Text == Tile9.Text)
                {
                    Tile7.BackColor = Color.Green;
                    Tile7.ForeColor = Color.White;
                    Tile8.BackColor = Color.Green;
                    Tile8.ForeColor = Color.White;
                    Tile9.BackColor = Color.Green;
                    Tile9.ForeColor = Color.White;

                    if (Tile7.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!");
                        playerX++;
                        DisplayXScore.Text = playerX.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!");
                        playerO++;
                        DisplayOScore.Text = playerO.ToString();
                    }
                    cleargame();

                }
            }

            if (Tile1.Text != "" && Tile4.Text != "" && Tile7.Text != "")
            {
                if (Tile1.Text == Tile4.Text && Tile1.Text == Tile7.Text)
                {
                    Tile1.BackColor = Color.Green;
                    Tile1.ForeColor = Color.White;
                    Tile4.BackColor = Color.Green;
                    Tile4.ForeColor = Color.White;
                    Tile7.BackColor = Color.Green;
                    Tile7.ForeColor = Color.White;

                    if (Tile1.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!");
                        playerX++;
                        DisplayXScore.Text = playerX.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!");
                        playerO++;
                        DisplayOScore.Text = playerO.ToString();
                    }
                    cleargame();
                }
            }

            if (Tile2.Text != "" && Tile5.Text != "" && Tile8.Text != "")
            {
                if (Tile2.Text == Tile5.Text && Tile2.Text == Tile8.Text)
                {
                    Tile2.BackColor = Color.Green;
                    Tile2.ForeColor = Color.White;
                    Tile5.BackColor = Color.Green;
                    Tile5.ForeColor = Color.White;
                    Tile8.BackColor = Color.Green;
                    Tile8.ForeColor = Color.White;

                    if (Tile2.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!");
                        playerX++;
                        DisplayXScore.Text = playerX.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!");
                        playerO++;
                        DisplayOScore.Text = playerO.ToString();
                    }
                    cleargame();
                }
            }

            if (Tile3.Text != "" && Tile6.Text != "" && Tile9.Text != "")
            {
                if (Tile3.Text == Tile6.Text && Tile3.Text == Tile9.Text)
                {
                    Tile9.BackColor = Color.Green;
                    Tile9.ForeColor = Color.White;
                    Tile6.BackColor = Color.Green;
                    Tile6.ForeColor = Color.White;
                    Tile3.BackColor = Color.Green;
                    Tile3.ForeColor = Color.White;

                    if (Tile3.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!");
                        playerX++;
                        DisplayXScore.Text = playerX.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!");
                        playerO++;
                        DisplayOScore.Text = playerO.ToString();
                    }
                    cleargame();
                }
            }

            if (Tile1.Text != "" && Tile5.Text != "" && Tile9.Text != "")
            {
                if (Tile1.Text == Tile5.Text && Tile1.Text == Tile9.Text)
                {
                    Tile1.BackColor = Color.Green;
                    Tile1.ForeColor = Color.White;
                    Tile5.BackColor = Color.Green;
                    Tile5.ForeColor = Color.White;
                    Tile9.BackColor = Color.Green;
                    Tile9.ForeColor = Color.White;

                    if (Tile1.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!");
                        playerX++;
                        DisplayXScore.Text = playerX.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!");
                        playerO++;
                        DisplayOScore.Text = playerO.ToString();
                    }
                    cleargame();
                }
            }

            if (Tile7.Text != "" && Tile5.Text != "" && Tile3.Text != "")
            {
                if (Tile7.Text == Tile5.Text && Tile7.Text == Tile3.Text)
                {
                    Tile7.BackColor = Color.Green;
                    Tile7.ForeColor = Color.White;
                    Tile5.BackColor = Color.Green;
                    Tile5.ForeColor = Color.White;
                    Tile3.BackColor = Color.Green;
                    Tile3.ForeColor = Color.White;

                    if (Tile7.Text == "X")
                    {
                        MessageBox.Show("Player X Wins!");
                        playerX++;
                        DisplayXScore.Text = playerX.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player O Wins!");
                        playerO++;
                        DisplayOScore.Text = playerO.ToString();
                    }
                    cleargame();

                }
            }
        }



        public void cleargame()
        {
            TurnDisplay.Text = "Player X";
            turn = 1;
            click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
            Tile1.Text = "";
            Tile2.Text = "";
            Tile3.Text = "";
            Tile4.Text = "";
            Tile5.Text = "";
            Tile6.Text = "";
            Tile7.Text = "";
            Tile8.Text = "";
            Tile9.Text = "";
            Tile1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            Tile1.ForeColor = Color.Black;
            Tile1.UseVisualStyleBackColor = false;
            Tile2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            Tile2.ForeColor = Color.Black;
            Tile2.UseVisualStyleBackColor = false;
            Tile3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            Tile3.ForeColor = Color.Black;
            Tile3.UseVisualStyleBackColor = false;
            Tile4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            Tile4.ForeColor = Color.Black;
            Tile4.UseVisualStyleBackColor = false;
            Tile5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            Tile5.ForeColor = Color.Black;
            Tile5.UseVisualStyleBackColor = false;
            Tile6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            Tile6.ForeColor = Color.Black;
            Tile6.UseVisualStyleBackColor = false;
            Tile7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            Tile7.ForeColor = Color.Black;
            Tile7.UseVisualStyleBackColor = false;
            Tile8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            Tile8.ForeColor = Color.Black;
            Tile8.UseVisualStyleBackColor = false;
            Tile9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            Tile9.ForeColor = Color.Black;
            Tile9.UseVisualStyleBackColor = false;
        }

    }
}
