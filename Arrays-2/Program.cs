using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];
            Random rm = new Random();

            for (int i = 0; i < 20; i++)
            {
                nums[i] = rm.Next(1, 20);
                if (nums[i] % 2 == 0)
                {
                    Console.Write(nums[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
