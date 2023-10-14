using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_test;

namespace Module_01
{
    public class Assignment
    {
        public string Missing(int[] array)
        {
            try
            {
                int Sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    Sum += array[i];
                }


                return Sum.ToString();
            }
            catch
            {

                return "Crazy input!";
            }

        }
    }
}
