using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class gameform : Form
    {
        public gameform()
        {
            InitializeComponent();
            game g = new game();
            utility.g = g;
            terminate();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(utility.move == false)
            {
                bool move = utility.g.move(0, 0, 0);
                if(move )
                {
                    btn1.Text = "O";
                    utility.move = true;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            else
            {
                bool move = utility.g.move(0, 0, 1);
                if (move)
                {
                    btn1.Text = "X";
                    utility.move = false;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            terminate();
        }

        private void b01_Click(object sender, EventArgs e)
        {
            if (utility.move == false)
            {
                bool move = utility.g.move(0, 1, 0);
                if (move)
                {
                    b01.Text = "O";
                    utility.move = true;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            else
            {
                bool move = utility.g.move(0, 1, 1);
                if (move)
                {
                    b01.Text = "X";
                    utility.move = false;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            terminate();
        }

        private void b02_Click(object sender, EventArgs e)
        {
            if (utility.move == false)
            {
                bool move = utility.g.move(0, 2, 0);
                if (move)
                {
                    b02.Text = "O";
                    utility.move = true;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            else
            {
                bool move = utility.g.move(0, 2, 1);
                if (move)
                {
                    b02.Text = "X";
                    utility.move = false;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            terminate();
        }

        private void b10_Click(object sender, EventArgs e)
        {
            if (utility.move == false)
            {
                bool move = utility.g.move(1, 0, 0);
                if (move)
                {
                    b10.Text = "O";
                    utility.move = true;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            else
            {
                bool move = utility.g.move(1, 0, 1);
                if (move)
                {
                    b10.Text = "X";
                    utility.move = false;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            terminate();
        }

        private void b11_Click(object sender, EventArgs e)
        {
            if (utility.move == false)
            {
                bool move = utility.g.move(1, 1, 0);
                if (move)
                {
                    b11.Text = "O";
                    utility.move = true;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            else
            {
                bool move = utility.g.move(1, 1, 1);
                if (move)
                {
                    b11.Text = "X";
                    utility.move = false;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            terminate();
        }

        private void b12_Click(object sender, EventArgs e)
        {
            if (utility.move == false)
            {
                bool move = utility.g.move(1, 2, 0);
                if (move)
                {
                    b12.Text = "O";
                    utility.move = true;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            else
            {
                bool move = utility.g.move(1, 2, 1);
                if (move)
                {
                    b12.Text = "X";
                    utility.move = false;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            terminate();
        }

        private void b20_Click(object sender, EventArgs e)
        {
            if (utility.move == false)
            {
                bool move = utility.g.move(2, 0, 0);
                if (move)
                {
                    b20.Text = "O";
                    utility.move = true;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            else
            {
                bool move = utility.g.move(2, 0, 1);
                if (move)
                {
                    b20.Text = "X";
                    utility.move = false;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            terminate();
        }

        private void b21_Click(object sender, EventArgs e)
        {
            if (utility.move == false)
            {
                bool move = utility.g.move(2, 1, 0);
                if (move)
                {
                    b21.Text = "O";
                    utility.move = true;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            else
            {
                bool move = utility.g.move(2, 1, 1);
                if (move)
                {
                    b21.Text = "X";
                    utility.move = false;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            terminate();
        }

        private void b22_Click(object sender, EventArgs e)
        {
            if (utility.move == false)
            {
                bool move = utility.g.move(2, 2, 0);
                if (move)
                {
                    b22.Text = "O";
                    utility.move = true;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            else
            {
                bool move = utility.g.move(2, 2, 1);
                if (move)
                {
                    b22.Text = "X";
                    utility.move = false;
                }
                else
                {
                    MessageBox.Show("Cannot Input on other's box");
                }
            }
            terminate();
        }

        public void terminate()
        {
            if(utility.curr_winner != "nobody")
            {
                congo congo = new congo();
                congo.Show();
                this.Hide();
            }
            else
            {
                if (utility.move == false)
                {
                    move_lb.Text = utility.player_1 + "\'s move";
                }
                else
                {
                    move_lb.Text = utility.player_2 + "\'s move";
                }
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
