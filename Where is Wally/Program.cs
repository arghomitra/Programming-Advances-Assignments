using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Where_is_Wally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = File.ReadAllText("names.txt");
            string[] nameArray = file.Split("\r\n");
            
            for (int i = 0; i < nameArray.Length - 1; i++)
            {
                for (int j = i + 1; j < nameArray.Length; j++)
                {
                    if (string.Compare(nameArray[i], nameArray[j]) > 0)
                    {
                        string temp = nameArray[i];
                        nameArray[i] = nameArray[j];
                        nameArray[j] = temp;
                    }
                }
            }
            
            Find find = new Find();
            Console.WriteLine("index : "+find.Wally(nameArray));

        }
    }
    public class Find
    {

        public int Wally(string[] nameArray)
        {


            int start = 0;
            int end = nameArray.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                int comparisonResult = string.Compare(nameArray[mid], "Wally");

                if (comparisonResult == 0)
                {
                    return mid;
                }
                else if (comparisonResult < 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return -1;
        }
    }
}