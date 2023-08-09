using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking_app
{
    internal class account
    {
        public int id;
        public string name;
        public string password;
        public double balance;

        public List<transaction> transactions;

        public account(int id, string name,  double balance, string password)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
            this.transactions = new List<transaction>();
            this.password = password;
        }

        public void credit(double amount)
        {
            balance += amount;
        }

        public void debit(double amount)
        {
            if(amount > 0 && amount <= balance) 
            {
                balance -= amount;
            }
        }

        public double showbalance()
        {
            return balance;
        }

        public void show_history()
        {
            string printable = "";
            foreach(transaction trx in transactions)
            {
                printable += trx.get_trx();
                printable += "\n";
            }

            MessageBox.Show(printable);
        }
    }
}
