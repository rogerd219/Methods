﻿//Roger Dominguez
// 2/6/2020
// Using a method to display input and output of user name
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare name a string
            string name;
            //Ask User for an input
            Console.Write("INPUT: ");
            // Read User input
            name = Console.ReadLine();
            // Display output based on user input
            Console.WriteLine("OUTPUT: Hello {0}!", name);

        }
    }
}
