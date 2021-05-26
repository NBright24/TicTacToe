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
        int player1 = 0, player2 = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Tile1_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    Tile1.Text = "x";
                    click1++;
                }
                else
                {
                    Tile1.Text = "0";
                    click1++;
                }
                turn++;
            }
            else
            {
                Tile1.Text = Tile1.Text;
            }
         
        }
    }
}
