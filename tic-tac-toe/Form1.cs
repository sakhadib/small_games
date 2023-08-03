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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1 != null && textBox2 != null)
            {
                utility.player_1 = textBox1.Text;
                utility.player_2 = textBox2.Text;
                
                gameform g1 = new gameform();
                g1.Show();
                this.Hide();
            }
        }
    }
}
