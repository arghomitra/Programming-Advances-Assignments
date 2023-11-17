using System;
using System.Collections.Generic;
using Module_05;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    class Subset //{{1 1 1}}
    {
        public void Combinationas(int number, int start, List<int> sublist, List<List<int>> result)
        {
            if (number == 0)
            {
                result.Add(new List<int>(sublist));
                return;
            }
            for (int i = start; i <= number; i++)
            {
                sublist.Add(i);
                Combinationas(number - i, i, sublist, result);
                sublist.RemoveAt(sublist.Count-1);

            }
        }
    }
}
