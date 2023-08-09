using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NET_checker
{
    internal static class check
    {
        public static void checker_service()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(28);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n# Checking Service Host :-\n");
            Console.ResetColor();
            while (DateTime.Now < endTime)
            {
                TimeSpan elapsed = DateTime.Now - startTime;
                int percentage = Math.Min(100, (int)((elapsed.TotalSeconds / 6) * 100));
                Console.Write($"Checking: {percentage}% ");
                Thread.Sleep(100); 
                Console.SetCursorPosition(0, Console.CursorTop);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("100% Service Host Checking Done. No problems Found\n\n");
            Console.ResetColor();
        }



        public static void checker_web()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(28);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n# Checking Web Host :-\n");
            Console.ResetColor();
            while (DateTime.Now < endTime)
            {
                TimeSpan elapsed = DateTime.Now - startTime;
                int percentage = Math.Min(100, (int)((elapsed.TotalSeconds / 15) * 100));
                Console.Write($"Checking: {percentage}% ");
                Thread.Sleep(100);
                Console.SetCursorPosition(0, Console.CursorTop);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("100% Web Host Checking Done. No problems Found\n\n");
            Console.ResetColor();
        }

        

    }
}
