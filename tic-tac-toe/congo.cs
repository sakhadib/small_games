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
    public partial class congo : Form
    {
        public congo()
        {
            InitializeComponent();

            p1_pt.Text = utility.player_1 + "  : " + utility.p1_pts;
            p2_pt.Text = utility.player_2 + "  : " + utility.p2_pts;


            if (utility.curr_winner == utility.player_1)
            {
                name_lbl.Text = utility.player_1 + " won the game";
            }
            else if(utility.curr_winner == utility.player_2)
            {
                name_lbl.Text = utility.player_2 + " won the game";
            }
            else if(utility.curr_winner == "draw")
            {
                name_lbl.Text = "The Game is a Draw";
                label1.Text = "";
            }
            else
            {
                name_lbl.Text = "error occured";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            utility.init();
            gameform g1 = new gameform();
            g1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
