using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_sort
{
    class Quicksort
    {
        public List<int> Sort(List<int> list)
        {
            if (list.Count <= 1) return list;
            
            int pivot = list[0];

            List<int> smaller = new List<int>();
            List<int> greater = new List<int>();

            foreach (int item in list)
            {
                if (item < pivot)
                {
                    smaller.Add(item);
                }
                else if(item > pivot)
                {
                    greater.Add(item);
                }

            }
            return Sort(smaller).Union(new List<int> { pivot }).Union(Sort(greater)).ToList<int>();

        }
    }
}
