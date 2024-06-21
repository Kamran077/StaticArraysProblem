using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -10 və 30 arasında random rəqəmlərdən ibarət ölçüsü 10 olan
            //massiv yaradın.Birinci mənfi ədəddən sonra gələn bütün rəqəmləri
            //toplayan program yazın. (1, 2, -3, 4, 5, -6, 7 bu halda, 4 + 5 + (-6) + 7
            //olacaq)
            int[] nums = new int[10];
            Random rm = new Random();
            int sum = 0;
            bool foundNegative = false;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rm.Next(-10, 31);
            }
            foreach (int numbers in nums)
            {
                Console.Write(numbers + " ");
            }

            foreach (int numbers in nums)
            {
                if (foundNegative)
                {
                    sum += numbers;
                }
                else if (numbers < 0)
                {
                    foundNegative = true;
                }
            }
            Console.WriteLine("\nSUM : {0}", sum);

            Console.ReadLine();
        }
    }
}
