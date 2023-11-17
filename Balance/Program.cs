using System;
using System.IO;
using System.Collections.Generic;

namespace Module_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //([{{[()]}}]))
            //This {is} a balanced [string]!
            string input = Console.ReadLine();

            Assignment assignment = new Assignment();
            Console.WriteLine(assignment.Balance(input));

        }

    }
    public class Assignment
    {
        public string Balance(string input) 
        {
            

            Stack<string> stack = new Stack<string>();

            foreach (char c in input)
            {
                if (c.ToString() =="(" || c.ToString() == "{" || c.ToString() == "[" || c.ToString() == "<")
                {
                    stack.Push(c.ToString());
                }
                else if (c.ToString() == ")" || c.ToString() == "}" || c.ToString() == "]" || c.ToString() == ">")
                {
                    if(stack.Count == 0)
                    {
                        return "Too many close symbols";
                    }
                    string bracket = stack.Pop();
                    if (bracket == "(" && c.ToString() != ")" || bracket == "{" && c.ToString() != "}" || bracket == "[" && c.ToString() != "]")
                    {
                        return "Not Balanced expression";
                    }


                }

            }
            if (stack.Count >0)
            {
                 return "Too many open symbolsreturn";
            }
            
            return "Balanced expression!";
            


        }

    }
}