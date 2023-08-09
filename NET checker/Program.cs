using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NET_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            check.checker_service();
            check.checker_web();

            Console.ReadKey();
        }

        
    }
}
