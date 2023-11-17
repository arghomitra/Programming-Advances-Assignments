using System;
using System.IO;

namespace Module_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            Assignment assignment = new Assignment();
            foreach (string word in input)
            {
                Console.Write(assignment.Unique(word)+" ");
            }
            

        }
        public class Assignment
        {
            public string Unique(string input, string result = "", int i=0 )
            {

                if (i>=input.Length)
                {
                    return result;
                }
                
                           
                if (!result.Contains(input[i].ToString()))
                {
                    result += input[i];
                }
                //if (Char.IsWhiteSpace(input[i]))
                //{
                //    result = "";
                //}
                return Unique(input,result ,i+1);
            }
        }
    }
}