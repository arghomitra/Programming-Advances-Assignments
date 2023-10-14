using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assignment assignment = new Assignment();
                String start = Console.ReadLine();
                string filename = "words.txt";
               

                string conditional_words = assignment.Duplicates(start, filename);

                Console.WriteLine(conditional_words);

            }
            catch (Exception ex)
            {

                Console.WriteLine("exception " + ex.Message);
            }
        }
    }
    public class Assignment
    {
        public string Duplicates(string start, string filename)
        {
            try
            {
                string fileText = File.ReadAllText(filename);
                Regex rx = new Regex(@$"\b{start}\w*\b", RegexOptions.IgnoreCase);

                MatchCollection matches = rx.Matches(fileText);
                string words = string.Empty;
                foreach (Match match in matches)
                {
                    words += match.Value + " ";
                }

                string[] wordsArray = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string duplicateWords = string.Empty;
                for (int i = 0; i < wordsArray.Length - 1; i++)
                {

                    if (wordsArray[i] == wordsArray[i + 1])
                    {
                        duplicateWords += wordsArray[i] + " ";
                    }

                }

                if (string.IsNullOrEmpty(duplicateWords))
                {
                    return "No duplicates found.";

                }
                else
                {
                    return duplicateWords;
                }

            }
            catch
            {
                return "Crazy input!";
            }
        }
    }
}