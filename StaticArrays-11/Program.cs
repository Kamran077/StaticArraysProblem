using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-30 və 20 arasında random rəqəmlərdən ibarət ölçüsü 10 olan
            //massiv yaradın.Birinci müsbət ədəddən sonra gələn bütün rəqəmləri
            //toplayan program yazın.
            int[] nums = new int[10];
            Random rm = new Random();
            int sum = 0;
            bool foundPositive = false;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rm.Next(-30, 20);
            }
            foreach (int numbers in nums)
            {
                Console.Write(numbers + " ");
            }
            foreach (int numbers in nums)
            {
                if (foundPositive)
                {
                    sum += numbers;
                }
                else if (numbers > 0)
                {
                    foundPositive = true;
                }
            }
            Console.WriteLine("\nSum : {0}", sum);
            Console.ReadLine();

        }
    }
}
