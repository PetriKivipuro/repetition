﻿using System;

namespace exercise_34
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            while (true)
            {
                Console.WriteLine("Do you want to continue?");
                string uWant = Console.ReadLine();

                if (uWant == "no")
                {
                    break;
                }
            }
        }
    }
}
