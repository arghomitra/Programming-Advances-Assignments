using System.Threading.Channels;
using System;
using System.IO;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace _05_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input_word = Console.ReadLine();
            List<List<string>> words = new List<List<string>>();
            List<string> subset = new List<string>();

            Assignment assignment = new Assignment();

            //assignment.Combinations(input_word, words, subset);

            int count = 0;
            string a = "";
            foreach (var item in words)
            {
                a += (String.Join("", item)) + " ";
                count++;
            }

            string modifiedContent = File.ReadAllText("english.txt");

            string[] array = a.Split(" ");
            // Console.WriteLine(a);
            Console.WriteLine(modifiedContent);

        }
    }
}