using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrays_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] charArr = new char[10];

            Random rm = new Random();

            for (int i = 0; i < charArr.Length; i++)
            {
                charArr[i] = (char)rm.Next(0, 256);
            }

            int letterCount = charArr.Count(char.IsLetter);
            int digitCount = charArr.Count(char.IsDigit);
            int punctuationCount = charArr.Count(char.IsPunctuation);

            Console.WriteLine("Char arrays are {0}", charArr);
            Console.WriteLine("Letter count is {0}", letterCount);
            Console.WriteLine("Digit count is {0}", digitCount);
            Console.WriteLine("Punctuation count is {0}", punctuationCount);

            Console.ReadLine();
        }
    }
}
