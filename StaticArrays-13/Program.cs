using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 ölçülü kəsr ədədlərdən ibarət massiv yaradın. Neçə rəqəmin
            //kesr hissəsinin olmadığını ekrana çıxaran program yazın. (məs: {
            //12,12.5, 10.1, 1,2} kəsr hissəsi olmayan ədədlər 3).
            double[] nums = { 12.5, 13.7, 13, 24, 24.6, 35, 26.4, 27.9, 28, 26.9 };
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
                if (nums[i] % 1 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("\nCount is {0}", count);

            Console.ReadLine();
        }
    }
}
