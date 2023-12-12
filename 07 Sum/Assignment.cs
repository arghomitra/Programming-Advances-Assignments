using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_Sum;

namespace Module_07
{
    public class Assignment
    {
        public List<int> Sum (int number)//20 
        {
            
            List<int> list = new List<int>();
            
            if (number==1|| number == 0)
            {
                list.Add(number);
                return list;
            }
            if (number%2 ==  0)
            {
                list.Add(number);//20 10
                list.AddRange(Sum(number / 2));//10 5
            }
            else if((number % 2) == 1)
            {
                list.Add(number);//5
                list.Add(3*number+1);
                list.AddRange(Sum((3 * number + 1) / 2));
            }
            return list;
        }

    }
}
