using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];
            int poscount = 0;
            int negcount = 0;
            int zerocount = 0;

            Random rm = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rm.Next(-5, 5);
                if (nums[i] > 0)
                {
                    poscount++;
                }
                else if (nums[i] < 0)
                {
                    negcount++;
                }
                else
                {
                    zerocount++;
                }
            }
            foreach (int nums1 in nums)
            {
                Console.Write(nums1 + " ");
            }
            Console.WriteLine("\n***************************");

            Console.WriteLine("Positive numbers count are {0}",poscount);
            Console.WriteLine("Negative numbers count are {0}", negcount);
            Console.WriteLine("Zero count is {0}", zerocount);


            Console.ReadLine();
        }
    }
}
