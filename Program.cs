﻿/*
 * Eric Martinez
 * July 13, 2025
 * Week 3 Project - Simple Calculator App
 * C#
 * This program implements a simple calculator that performs basic arithmetic operations
 * such as addition, subtraction, multiplication, division, and modulus.
 */

using System;

class CalculatorApp
{
    static void ShowMenu()
    {
        Console.WriteLine("Please select an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Modulus");
        Console.WriteLine("6. Memory");
        Console.WriteLine("7. Exit");
    }
    static void HandleChoice()
    {
        int choice = InputValidator.ReadMenuChoice("Enter your choice (1-7): ");
        switch (choice)
        {
            case 1:
                Console.WriteLine("You selected Addition.");
                int num1 = InputValidator.ReadInt("Enter the first number: ");
                int num2 = InputValidator.ReadInt("Enter the second number: ");
                int sum = Calculator.Add(num1, num2);
                Console.WriteLine($"{num1} + {num2} = {sum}\n");
                break;
            case 2:
                Console.WriteLine("You selected Subtraction.");
                int subNum1 = InputValidator.ReadInt("Enter the first number: ");
                int subNum2 = InputValidator.ReadInt("Enter the second number: ");
                int difference = Calculator.Subtract(subNum1, subNum2);
                Console.WriteLine($"{subNum1} - {subNum2} = {difference}\n");
                break;
            case 3:
                Console.WriteLine("You selected Multiplication.");
                int mulNum1 = InputValidator.ReadInt("Enter the first number: ");
                int mulNum2 = InputValidator.ReadInt("Enter the second number: ");
                int product = Calculator.Multiply(mulNum1, mulNum2);
                Console.WriteLine($"{mulNum1} * {mulNum2} = {product}\n");
                break;
            case 4:
                Console.WriteLine("You selected Division.");
                double divNum1 = InputValidator.ReadDouble("Enter the first number: ");
                double divNum2 = InputValidator.ReadDouble("Enter the second number: ");
                double quotient = Calculator.Divide(divNum1, divNum2);
                Console.WriteLine($"{divNum1} / {divNum2} = {quotient}\n");
                break;
            case 5:
                Console.WriteLine("You selected Modulus.");
                int modNum1 = InputValidator.ReadInt("Enter the first number: ");
                int modNum2 = InputValidator.ReadInt("Enter the second number: ");
                int modulus = Calculator.Modulus(modNum1, modNum2);
                Console.WriteLine($"{modNum1} % {modNum2} = {modulus}\n");
                break;
            case 6:
                Console.WriteLine("You selected Memory.");
                Memory memory = new Memory();
                memory.ShowMemoryMenu();
                break;
              case 7:
                Console.WriteLine("Exiting...");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

    }
    static void Main()
    {
        Console.WriteLine("Week 3 Project - Simple Calculator by Eric Martinez");
        Console.WriteLine("Welcome to the Simple Calculator!");
        while (true)
        {
            // Show menu
            ShowMenu();
            // Handle user choice
            HandleChoice();
        }
    }
}
