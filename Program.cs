using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks_Arrays_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Ölçüsü 5 olan massivə rəqəmlər daxil edin, daha sonra həmin
            // massivi tərsinə ekrana çıxarın.
            int[] nums = new int[5];
            Console.Write("Enter the nums : ");

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 4; j >= 0; j--)
            {
                Console.Write(nums[j] + " ");
            }

            Console.ReadLine();
        }
    }
}
