
using Module_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace _02_Space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            string input = string.Empty;
            
            while (!String.IsNullOrWhiteSpace(line = Console.ReadLine()))
            {
                input += line +"\n";

            }

            Assignment assignment = new Assignment();
            string signals = assignment.Space(input);
            Console.WriteLine(signals);



        }
    }
}