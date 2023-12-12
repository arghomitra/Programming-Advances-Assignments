using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Largest_bits
{
    class Assignment
    {
        public List<string> Solve(string input, List<string> result, int i=1)
        {
           
            if (i==input.Length+1)
            {
                return result;
            }
            
            result.Add(input);
            return Solve(input.Substring(i, input.Length - 1), result,i++);
        }
    }
}
