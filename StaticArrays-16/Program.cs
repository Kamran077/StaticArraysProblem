using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ölçüsü 10 olan massiv yaradın və içərsini random rəqəmlərlə
            //doldurun.Massivdəki rəqəmlərin yerlərini tərsinə çevirən program
            //yazın. (0 - cı indeksi 9 - la, 1 - i 8 - lə və s.)
            int[] nums = new int[10];
            Random rm = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rm.Next(0, 101);
            }
            Console.WriteLine("Array:");
            foreach (int numbers in nums)
            {
                Console.Write(numbers + " ");
            }
            Console.WriteLine("\nArray tersi: ");
            for (int j = nums.Length - 1; j >= 0; j--)
            {
                Console.Write(nums[j] + " ");
            }
            Console.ReadLine();
        }
    }
}
