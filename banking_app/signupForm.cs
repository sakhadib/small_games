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
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sun_btn_Click(object sender, EventArgs e)
        {
            string name = uname_tb.Text;
            string pass = pass_tb.Text;
            string repass = c_pass_tb.Text;

            if(pass ==  repass)
            {
                bool flag = true;
                foreach(account acc in utility.accounts)
                {
                    if(acc.name == name)
                    {
                        MessageBox.Show("Account username exists. Try another");
                        flag = false;
                        break;
                    }
                }
                if(flag == true)
                {
                    int accno = utility.accno;
                    utility.accno++;

                    account a = new account(accno, name, 0, pass);
                    utility.accounts.Add(a);   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
