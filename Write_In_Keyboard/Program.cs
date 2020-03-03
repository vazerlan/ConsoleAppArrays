using System;

namespace Write_In_Keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите количество элементов для массива");
            int count = int.Parse(Console.ReadLine());

            int[] myArray = new int[count];

            Console.WriteLine("Заполните массив: ");
            for (int i = 0; i < count; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nМассив myArray = { ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(myArray[i]);
                if (i < count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" }");

        }
    }
}
