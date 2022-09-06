using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment_Test
{
    class Program_2
    {
        static void Program(string[] args)
        {
            Console.WriteLine("Assesment Program 2");
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.WriteLine("\n\nWrite a program in C# Sharp to Print all unique elements of an array");
            int[] arr = new int[1000];
            int number;
            Console.Write("\nInput the number of elements to be stored in the array :");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write($"Enter the {i + 1} element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            bool flag = false;
            int[] unique = new int[100];
            int uniCount = 0;
            for (int i = 0; i < number; i++)
            {
                for(int j = 0; j < number; j++)
                {
                    if(arr[i] == arr[j] && i!=j)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    unique[uniCount] = arr[i];
                    uniCount++;
                }
                flag = false;
            }
            if (uniCount == 0)
            {
                Console.Write("Unique elements in the array are : 0");
            }
            else
            {
                Console.Write("Unique elements in the array are : ");
                for (int i = 0; i < uniCount; i++)
                {
                    Console.Write($"{unique[i]} ");
                }
            }
            

        }
    }
}
