using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Words
{
    class Assignment
    {
        public void Combinations(string input_word, List<List<string>> words, List<string> subset, int index = 0)
        {

            words.Add(new List<string>(subset)); //otherwise adding reference
            for (int i = index; i < input_word.Length; i++)
            {
                subset.Add(input_word[i].ToString());
                Combinations(input_word, words, subset, i + 1);
                subset.RemoveAt(subset.Count - 1);
            }

        }
    }
}
