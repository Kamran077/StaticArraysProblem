using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ölçüsü 10 olan massiv yaradın və içərsini random rəqəmlərlə
            //doldurun.Massivdəki qonşu elementlərin yerini dəyişən program yazın.
            int[] nums = new int[10];
            Random rm = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rm.Next(1, 101);
            }
            Console.WriteLine("Array:");
            foreach (int numbers in nums)
            {
                Console.Write(numbers + " ");
            }
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                int aux = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = aux;
            }
            Console.WriteLine("\nArray tersi:");
            foreach (int numbers in nums)
            {
                Console.Write(numbers + " ");
            }
            Console.ReadLine();
        }
    }
}
