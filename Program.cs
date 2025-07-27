/*
 * Eric Martinez
 * July 19, 2025
 * Week 5 Project - Simple Calculator App
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
        Console.WriteLine("7. Multi-Number Operations");
        Console.WriteLine("8. Exit");
    }

    static void HandleChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("You selected Addition.");
                int a1 = InputValidator.ReadInt("Enter the first number: ");
                int a2 = InputValidator.ReadInt("Enter the second number: ");
                int sum = Calculator.Add(a1, a2);
                Console.WriteLine($"{a1} + {a2} = {sum}\n");
                break;

            case 2:
                Console.WriteLine("You selected Subtraction.");
                int s1 = InputValidator.ReadInt("Enter the first number: ");
                int s2 = InputValidator.ReadInt("Enter the second number: ");
                int diff = Calculator.Subtract(s1, s2);
                Console.WriteLine($"{s1} - {s2} = {diff}\n");
                break;

            case 3:
                Console.WriteLine("You selected Multiplication.");
                int m1 = InputValidator.ReadInt("Enter the first number: ");
                int m2 = InputValidator.ReadInt("Enter the second number: ");
                int product = Calculator.Multiply(m1, m2);
                Console.WriteLine($"{m1} * {m2} = {product}\n");
                break;

            case 4:
                Console.WriteLine("You selected Division.");
                try
                {
                    double d1 = InputValidator.ReadDouble("Enter the first number: ");
                    double d2 = InputValidator.ReadDouble("Enter the second number: ");
                    double result = Calculator.Divide(d1, d2);
                    Console.WriteLine($"{d1} / {d2} = {result:F2}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }
                break;

            case 5:
                Console.WriteLine("You selected Modulus.");
                try
                {
                    int mod1 = InputValidator.ReadInt("Enter the first number: ");
                    int mod2 = InputValidator.ReadInt("Enter the second number: ");
                    int mod = Calculator.Modulus(mod1, mod2);
                    Console.WriteLine($"{mod1} % {mod2} = {mod}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }
                break;

            case 6:
                Memory mem = new Memory();
                mem.ShowMemoryMenu();
                break;

            case 7:
                Console.WriteLine("Multi-Number Operations:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                int op = InputValidator.ReadMenuChoice("Choose an operation (1-4): ");

                switch (op)
                {
                    case 1:
                        int[] addNums = InputValidator.ReadIntList("Enter numbers to add: ");
                        Console.WriteLine($"Sum = {Calculator.Add(addNums)}\n");
                        break;
                    case 2:
                        int[] subNums = InputValidator.ReadIntList("Enter numbers to subtract: ");
                        Console.WriteLine($"Result = {Calculator.Subtract(subNums)}\n");
                        break;
                    case 3:
                        int[] mulNums = InputValidator.ReadIntList("Enter numbers to multiply: ");
                        Console.WriteLine($"Result = {Calculator.Multiply(mulNums)}\n");
                        break;
                    case 4:
                        try
                        {
                            double[] divNums = InputValidator.ReadDoubleList("Enter numbers to divide: ");
                            Console.WriteLine($"Result = {Calculator.Divide(divNums):F2}\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}\n");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation.\n");
                        break;
                }
                break;

            default:
                Console.WriteLine("Invalid choice.\n");
                break;
        }
    }

    static void Main()
    {
        bool running = true;
        Console.WriteLine("Eric Martinez - Project Week 5 - Exception Handling");
        Console.WriteLine("Welcome to the enhanced calculator!\n");

        while (running)
        {
            ShowMenu();
            int choice = InputValidator.ReadMenuChoice("Enter your choice (1-8): ");
            if (choice == 8)
            {
                Console.WriteLine("Exiting calculator. Goodbye!");
                running = false;
            }
            else
            {
                HandleChoice(choice);
            }
        }
    }
}
