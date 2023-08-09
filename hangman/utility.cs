using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hangman
{
    internal static class utility
    {
        public static List<string> words = new List<string>();

        public static int point;
        public static string cur_word;
        public static List<char> wordList;

        public static string filePath = @"D:\Repos\Mini_Games\hangman\word.txt";    

        public static void init()
        {
            point = 0;

            if (File.Exists(filePath))
            {
                // Create a StreamReader to read the file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read the content of the file line by line
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Do something with the line, for example, display it in a TextBox
                        words.Add(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("The file 'words.txt' does not exist in the solution folder.");
            }
        }
    }
}
