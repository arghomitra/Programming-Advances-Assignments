using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                string filename = "words (1)";
                Assignment assignment = new Assignment();

                Console.WriteLine(assignment.NthCharacter(number, filename));

            }
            catch 
            {

                Console.WriteLine("Crazy input!");
            }
            
            
        }
    }
    public class Assignment
    {
        public string NthCharacter(int number, string filename)
        {
            try
            {
                string file = File.ReadAllText($"words.txt");
                string fileText = file.Replace(" ", "").Replace("\r", "").Replace("\n", "");
                
                char nthchar = fileText[number];

                return nthchar.ToString();
            }
            catch (Exception ex)
            {
                return "Crazy input!";
            }
        }
    }
}