using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ölçüsü 50 olan massiv yaradın və içərisini random doldurun(1-100) .
            //İstifadəçi 1 - 100 arasında rəqəm daxil edir, və massivdə bu əddədən
            //neçə dənə olduğunu hesablayan program yazın.

            int[] nums = new int[50];
            Random rm = new Random();
            int usernum;
            int count = 0;
            Console.Write("Please enter the one number: ");
            usernum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rm.Next(1, 100);
                if (nums[i] == usernum)
                {
                    count++;
                }
            }
            foreach (int numbers in nums)
            {
                Console.Write(numbers + " ");
            }

            Console.WriteLine("\nThe numbers of same items: {0}", count);
            Console.ReadLine();
        }
    }
}
