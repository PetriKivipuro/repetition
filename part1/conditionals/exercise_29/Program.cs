﻿using System;

namespace exercise_29
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("Give the first number!");
            int eka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the second number!");
            int toka = Convert.ToInt32(Console.ReadLine());

            if (eka < toka)
            {
                Console.WriteLine("The larger number is " + toka + "!");
            }

            else if (eka > toka)
            {
                Console.WriteLine("The larger number is " + eka + "!");

            }

            if (eka == toka)
            {
                Console.WriteLine("They are equal!");
            }




        }
    }
}
