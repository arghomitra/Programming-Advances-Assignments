using System;
using System.IO;
namespace Module_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] input_array = input.Split(" ");
            int[] nums = Array.ConvertAll(input_array,int.Parse);
            Assignment assignment = new Assignment();
            Console.WriteLine(assignment.Missing(nums));

        }

        public class Assignment
        {
            public int Missing(int[] nums)
            {
                int missing_num = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[i] < nums[j])
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }
                

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if ((nums[i + 1] - nums[i] != 1) && (nums[i] + 1 > 0))
                    {
                        missing_num =  nums[i] + 1;
                        break;
                    }
                }
                return missing_num;
            }
        }
    }
}