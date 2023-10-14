using System;
using System.IO;
using Module_01;

namespace Module_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] inputArray = Console.ReadLine().Split(' ');
                int[] numbers = Array.ConvertAll(inputArray, int.Parse);

                Assignment searching = new Assignment();

                // math formula sum = ((last_number - first_number + 1) * (first_number + last_number)) / 2

                int exactSum = ((numbers[numbers.Length - 1] - numbers[0] + 1) * (numbers[0] + numbers[numbers.Length - 1])) / 2;
                int missing_number = exactSum - int.Parse(searching.Missing(numbers)) ;
                if (missing_number != 0)
                {
                    Console.WriteLine(missing_number);
                }
                else
                {
                    Console.WriteLine("No missing number.");
                }
            }
            catch 
            {

                Console.WriteLine("Crazy input!");
            }
            
            
        }
        
    }
}