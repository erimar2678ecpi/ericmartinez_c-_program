﻿/*
 * Eric Martinez
 * June 21, 2025
 * Week 1 Project - IO & Operators
 * Description: Console app that performs basic integer addition and floating-point subtraction with formatted output and input validation.
 */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Week 1 Project - Simple Calculator by Eric Martinez");
        Console.WriteLine("Welcome to the Simple Calculator!");
        Console.WriteLine("You'll enter numbers for a few operations. Let's begin.\n");

        // Integer addition
        Console.WriteLine("INTEGER ADDITION");
        int int1 = ReadInt("Enter the first integer: ");
        int int2 = ReadInt("Enter the second integer: ");
        int intSum = int1 + int2;
        Console.WriteLine($"{int1} + {int2} = {intSum}\n");

        // Floating-point subtraction
        Console.WriteLine("FLOATING-POINT SUBTRACTION");
        double float1 = ReadDouble("Enter the first decimal number: ");
        double float2 = ReadDouble("Enter the second decimal number: ");
        double floatDiff = float2 - float1;
        Console.WriteLine($"{float2:F2} - {float1:F2} = {floatDiff:F2}\n");

        // Exit message
        Console.WriteLine("Thank you for using the calculator. Type 'exit' to close.");
        string response = Console.ReadLine();
        while (response.ToLower() != "exit")
        {
            Console.WriteLine("Please type 'exit' to end the program.");
            response = Console.ReadLine();
        }
    }

    static int ReadInt(string prompt)
    {
        int result;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
        }
        return result;
    }

    static double ReadDouble(string prompt)
    {
        double result;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Invalid input. Please enter a valid decimal number: ");
        }
        return result;
    }
}
