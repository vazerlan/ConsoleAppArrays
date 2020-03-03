using System;
using System.Linq;

namespace ConsoleAppArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Enumerable.Range(3, 4).ToArray();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
