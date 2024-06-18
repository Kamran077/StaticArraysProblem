using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 və 100 arasında random rəqəmlərdən ibarət ölçüsü 10 olan massiv
            //yaradın. 3 - ə, 5 - ə.7 - ə bölünən rəqəmlərin sayını tapın. (ayrı - ayrı).
            int[] nums = new int[10];
            Random rm = new Random();
            int count3 = 0;
            int count5 = 0;
            int count7 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rm.Next(1, 100);
                if (nums[i] % 3 == 0)
                {
                    count3++;
                }
                else if (nums[i] % 5 == 0)
                {
                    count5++;
                }
                else if (nums[i] % 7 == 0)
                {
                    count7++;
                }
            }
            foreach (int numbers in nums)
            {
                Console.Write(numbers + " ");
            }
            Console.WriteLine("\n3e bolunen: {0}", count3);
            Console.WriteLine("\n5e bolunen: {0}", count5);
            Console.WriteLine("\n7e bolunen: {0}", count7);


            Console.ReadLine();
        }
    }
}
