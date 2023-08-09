using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app
{
    internal class transaction
    {
        public int trx_id;
        public string status;
        public double amount;

        public transaction(int trx_id, string status, double amount)
        {
            this.trx_id = trx_id;
            this.status = status;
            this.amount = amount;
        }


        public string get_trx()
        {
            string ret = $"{trx_id}\t{status}\t{amount}";
            return ret ;
        }
    }
}
