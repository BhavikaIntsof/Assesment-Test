using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment_Test
{
    class Program_6
    {
        static void Program(string[] args)
        {
            string[] romanLetters = {
        "M",
        "CM",
        "D",
        "CD",
        "C",
        "XC",
        "L",
        "XL",
        "X",
        "IX",
        "V",
        "IV",
        "I"
    };
            int[] numbers = {
        1000,
        900,
        500,
        400,
        100,
        90,
        50,
        40,
        10,
        9,
        5,
        4,
        1
    }; 
            int number;
            Console.WriteLine("Enter the number you want to convert in roman");
            number = Convert.ToInt32(Console.ReadLine());
            string roman = string.Empty;
            int i = 0;
            while (number != 0)
            {
                if (number >= numbers[i])
                {
                    number -= numbers[i];
                    roman += romanLetters[i];
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine($"roman letter : {roman}");

        }



    }
}
