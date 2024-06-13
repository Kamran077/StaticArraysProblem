using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            double sum = 0;
            int count = 0; 
            double average;

            Random rm = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rm.Next(-20, 20);

                if (nums[i] > 0)
                {
                    sum += nums[i];
                    count++;
                }
            }

            foreach (int arr in nums)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine("\n**************");

            average = sum / count;
            Console.WriteLine(average);

            Console.ReadLine();
        }
    }
}
