using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 və 200 arasında random rəqəmlərdən ibarət ölçüsü 20 olan
            //massiv yaradın. 1 rəqəmli, 2 rəqəmli, 3 rəqəmli ədədlərin faiz nisbəti
            //ilə müqayisəsini edən program yazın.
            int size = 20;
            int[] nums = new int[size];
            Random rm = new Random();
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            for (int i = 0; i < size; i++)
            {
                nums[i] = rm.Next(1, 201);
                if (nums[i] / 10 == 0)
                {
                    count1++;
                }
                else if (nums[i] / 10 != 0 && nums[i] / 100  == 0)
                {
                    count2++;
                }
                else if (nums[i] / 100 != 0)
                {
                    count3++;
                }
            }
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n1 reqemli sayi " + count1 + "\n2 reqemli sayi " + count2 + "\n3 reqemli sayi " + count3);
            double percent1 = (count1 / (double)size) * 100;
            double percent2 = (count2 / (double)size) * 100;
            double percent3 = (count3 / (double)size) * 100;

            Console.WriteLine("\n1 reqemli faiz nisbeti: " + percent1 + "\n2 reqemli faiz nisbeti: " + percent2 + "\n3 reqemli faiz nisbeti: " + percent3);
            Console.ReadLine();
        }
    }
}
