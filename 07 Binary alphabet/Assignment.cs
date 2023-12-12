using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07
{
    class Assignment
    {
        public List<string> Binary(int input,int number =1 ) 
        {
            List <string> list = new List<string>();
            if (number > input) 
            { 
                return list;
            }
            string binary = Convert.ToString(number, 2);

            string binToAlpha = Alphabet(binary);

            list.Add(binToAlpha);
            list.AddRange(Binary(input,++number));
            return list;
            

        }
        public string Alphabet(string number, int i = 0, char c = 'a')
        {
            string result = string.Empty;
            
            if (i >= number.Length)
            {
                return result;
            }
            char x = number[i];

            if (x == '1')
            {
                result += c;
            }
            

            return result + Alphabet(number, i + 1, ++c);
            
        }
    }
}
