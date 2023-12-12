using Module_07;
using System;
using System.IO;
namespace _07_Binary_alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Assignment assignment = new Assignment();
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 0) { Console.WriteLine("Crazy input!"); }
                else
                {
                    Console.WriteLine(string.Join(" ", assignment.Binary(input)));
                }
                
            }
            catch (Exception)
            {

                Console.WriteLine("Crazy input!"); ;
            }
            

        }
    }
}