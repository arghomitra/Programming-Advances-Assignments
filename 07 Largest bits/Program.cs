using System.Collections.Generic;
using System;
using System.Collections.Immutable;

namespace _07_Largest_bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(input, 2);

            Assignment assignment = new Assignment();
            List<string> result = new List<string>();
            assignment.Solve(binary, result);

            //Console.WriteLine(string.Join(" ", assignment.Solve(binary,result)));
            Console.WriteLine(Convert.ToInt32( result[0],2)) ;

        }
    }
}