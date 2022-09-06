using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment_Test
{
    class Program_3
    {
         static void Program(string[] args)
        {
            int[,] matrix = new int[3, 3];
            Console.WriteLine("Assesment Program 3");
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.WriteLine("\n\nWrite a program in C# Sharp for a 2D array of size 3x3 and print the matrix.  ");
            Console.WriteLine("Input elements of matrix");
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i},{j}] : ");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n\n Entered Matrix is as follows");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                    Console.Write($"{matrix[i, j]}\t");
            }
            Console.Write("\n\n");
        }
    }
    
}
