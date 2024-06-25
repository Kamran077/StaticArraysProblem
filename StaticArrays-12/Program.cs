using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StaticArrays_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ölçüsü 20 olan və random rəqəmlərdən ibarət massiv yaradın.
            // Massivin maximum və minimum elemtini tapan program yazın.
            //(Dəyəri və indeksi qaytarın)
            int[] nums = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 100);
            }
            foreach (int numbers in nums)
            {
                Console.Write(numbers + " ");
            }

            int max = nums.Max();
            int min = nums.Min();
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max)
                {
                    maxIndex = i;
                }
                else if (nums[i] == min)
                {
                    minIndex = i;
                }
            }
            Console.WriteLine("\nMax value is " + max + " Index is " + maxIndex);
            Console.WriteLine("\nMin value is " + min + " Index is " + minIndex);

            Console.ReadLine();
        }
    }
}
