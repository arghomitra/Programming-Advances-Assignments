using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Module_03
{
    class sum
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Regex pettern = new Regex(@"\d+");
            MatchCollection matches = pettern.Matches(input);
            string numbers = string.Join("",matches);
            //Console.WriteLine(numbers);

            Assignment recurtion = new Assignment();
            Console.WriteLine(recurtion.Sum(numbers));

        }

        public class Assignment
        {

            public int Sum(string word)
            {
                if(word.Length ==0) return 0;

                return int.Parse(word[word.Length - 1].ToString())+Sum(word.Substring(0, word.Length - 1));
            }
        }

    }
}