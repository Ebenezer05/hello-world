﻿using System;

namespace hello_world2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;
            int sum = 0;


       
            Console.WriteLine("Enter the first number: ");

            number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");

            number2 = Int32.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("The sum of the values are: " + sum);

            Console.ReadLine();
        }
    }
}
