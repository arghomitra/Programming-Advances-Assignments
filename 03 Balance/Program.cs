using System;
using System.Collections.Generic;

public class BalancedBrackets
{
    public static string CheckBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input) //[{{[()]}}])
        {
            if (c == '(' || c == '[' || c == '{' || c == '<')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}' || c == '>')
            {
                if (stack.Count == 0)
                {
                    return "Too many close symbols";
                }
                char top = stack.Pop();
                if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{') || (c == '>' && top != '<'))
                {
                    return "Not balanced expression";
                }
            }
        }

        if (stack.Count > 0)
        {
            return "Too many open symbols";
        }

        return "Balanced expression";
    }
}

public class Program
{
    public static void Main()
    {
        string input = "([{{[()]}}]))";
        string result = BalancedBrackets.CheckBalanced(input);
        Console.WriteLine(result);
    }
}