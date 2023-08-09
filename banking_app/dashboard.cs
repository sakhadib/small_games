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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            utility.curr_acc.show_history();
        }

        private void update()
        {
            label4.Text = utility.curr_acc.id.ToString();
            label6.Text = utility.curr_acc.name.ToString();
            label8.Text = utility.curr_acc.balance.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double add = 0;
            try
            {
                add = Convert.ToDouble(textBox1.Text);
                transaction trx = new transaction(utility.trxno, "credit", add);
                utility.trxno++;
                utility.curr_acc.transactions.Add(trx);
                utility.curr_acc.credit(add);
                update();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sub = 0;
            try
            {
                sub = Convert.ToDouble(textBox2.Text);
                transaction trx = new transaction(utility.trxno, "debit", sub);
                utility.trxno++;
                utility.curr_acc.transactions.Add(trx);
                utility.curr_acc.debit(sub);
                update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
