using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 və 200 arasında random rəqəmlərdən ibarət ölçüsü 20 olan
            //massiv yaradın.Massivdəki bütün sadə rəqəmləri ekrana çıxaran
            //program yazın.
            int[] nums = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(2, 201);
            } 

            Console.WriteLine("Array:");
            foreach (int number in nums)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Prime numbers:");
            foreach (int number in nums)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                }
            }

            Console.ReadLine();
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
