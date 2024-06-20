using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 və 100 arasında random rəqəmlərdən ibarət ölçüsü 10 olan massiv
            //yaradın. 3 - ə bölünüb 5 - ə bölünməyən rəqəmlərin sayını çıxarın.(eyni
            //anda həm 3ə bölünsün həm 5 - ə bölünməsin)

            int[] nums = new int[10];
            Random rm = new Random();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rm.Next(1, 100);
                if (nums[i] % 3 == 0 && nums[i] % 5 != 0)
                {
                    count++; ;
                }
            }
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nCount is {0}", count);
            Console.ReadLine();

        }
    }
}
