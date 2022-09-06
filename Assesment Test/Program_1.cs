using System;

namespace Assesment_Test
{
    class Program_1
    {
        static void Program(string[] args)
        {
            Console.WriteLine("Assesment Program 1");
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.WriteLine("\n\nWrite a program in C# Sharp to find the sum of all elements of the array");
            int[] arr = new int[1000];
            int number, sum=0;

            Console.Write("\nInput the number of elements to be stored in the array :");
            number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                Console.Write($"Enter the {i+1} element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
            }
            Console.WriteLine($"\nThe Sum of the array elements is : {sum}");

        }
    }
}
