using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking_app
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

        private void login_btn_Click(object sender, EventArgs e)
        {
            string uname = uname_tb.Text;
            string pass = pass_tb.Text;

            foreach (account a in utility.accounts)
            {
                if(uname == a.name)
                {
                    if(pass == a.password)
                    {
                        utility.curr_acc = a;
                        dashboard d = new dashboard();
                        d.Show();
                        this.Hide();
                        break;
                    }
                }
            }
        }

        private void sun_btn_Click(object sender, EventArgs e)
        {
            signupForm s = new signupForm();
            s.Show();
            this.Hide();
        }
    }
}
