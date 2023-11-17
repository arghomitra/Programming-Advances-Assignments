using System;
using System.IO;
namespace Module_03
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                if (numbers.Length==2)
                {
                    Assignment assignment = new Assignment();
                    int baseCase = 0;
                    if (numbers[0] < 0 && numbers[1] < 0)
                    {
                        int num1 = Math.Max(numbers[0], -numbers[0]);
                        int num2 = Math.Max(numbers[1], -numbers[1]);
                        Console.WriteLine(assignment.Multiplication(num1, num2));
                    }
                    else if (numbers[0] > numbers[1])
                    {
                        baseCase = numbers[0];
                        Console.WriteLine(assignment.Multiplication(numbers[1], baseCase));
                    }

                    else if (numbers[0] < numbers[1])
                    {
                        baseCase = numbers[1];
                        Console.WriteLine(assignment.Multiplication(numbers[0], baseCase));
                    }
                }
                else
                {
                    Console.WriteLine("Crazy input!");
                }
                
                
            }
            catch 
            {

                Console.WriteLine("Crazy input!");
            }
            
            
        }

        public class Assignment
        {
            public int Multiplication(int num1,int baseCase) 
            {
                if (num1 == 0 || baseCase == 0)
                {
                    return 0;
                }
                if (Math.Max(baseCase, - baseCase) == 0) return 0;

                

               

                return num1 + Multiplication( num1, Math.Max(baseCase, -baseCase) - 1);
            }
        }
    }
}