using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            double oddsum = 0;
            int evensum = 0;
            double average = 0;
            int count = 0;
            Random rm = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rm.Next(1, 20);

                if (nums[i] % 2 == 0)
                {
                    evensum += nums[i];
                }
                else
                {
                    oddsum += nums[i];
                    count++;
                }
            }
            average = oddsum / count;
            foreach (int i in nums)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("*****************");

            Console.WriteLine(evensum);
            Console.WriteLine(average);


            Console.ReadLine();
        }
    }
}
