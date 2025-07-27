using System;
using System.Collections.Generic;
using System.Linq;

public class Memory
{
    private double? memoryValue = null;
    private List<double> memoryList = new List<double>();

    public void ShowMemoryMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMemory Menu:");
            Console.WriteLine("1. Store single value");
            Console.WriteLine("2. Retrieve single value");
            Console.WriteLine("3. Clear single value");
            Console.WriteLine("4. Replace single value");
            Console.WriteLine("5. Add one or more values to memory list");
            Console.WriteLine("6. Display memory list");
            Console.WriteLine("7. Count values in memory list");
            Console.WriteLine("8. Remove value from memory list");
            Console.WriteLine("9. Sum of memory list");
            Console.WriteLine("10. Average of memory list");
            Console.WriteLine("11. Difference (first - last) in memory list");
            Console.WriteLine("12. Exit Memory Menu");

            int choice = InputValidator.ReadInt("Choose an option: ");

            switch (choice.ToString())
            {
                case "1":
                    memoryValue = InputValidator.ReadDouble("Enter value to store in memory: ");
                    Console.WriteLine("Stored.");
                    break;

                case "2":
                    Console.WriteLine(memoryValue.HasValue
                        ? $"Stored value: {memoryValue:F2}"
                        : "No value in memory.");
                    break;

                case "3":
                    memoryValue = null;
                    Console.WriteLine("Memory cleared.");
                    break;

                case "4":
                    memoryValue = InputValidator.ReadDouble("Enter new value: ");
                    Console.WriteLine("Value replaced.");
                    break;

                case "5":
                    if (memoryList.Count >= 10)
                    {
                        Console.WriteLine("Memory list is full (max 10).");
                        break;
                    }

                    double[] newValues = InputValidator.ReadDoubleList("Enter up to 10 numbers separated by spaces: ");
                    int availableSpace = 10 - memoryList.Count;
                    double[] toAdd = newValues.Take(availableSpace).ToArray();

                    memoryList.AddRange(toAdd);
                    Console.WriteLine($"{toAdd.Length} value(s) added to memory.");
                    break;

                case "6":
                    if (memoryList.Count == 0)
                        Console.WriteLine("Memory list is empty.");
                    else
                        Console.WriteLine("Values: " + string.Join(", ", memoryList.Select(v => v.ToString("F2"))));
                    break;

                case "7":
                    Console.WriteLine($"Count: {memoryList.Count}");
                    break;

                case "8":
                    double removeVal = InputValidator.ReadDouble("Enter value to remove: ");
                    if (memoryList.Remove(removeVal))
                        Console.WriteLine("Value removed.");
                    else
                        Console.WriteLine("Value not found.");
                    break;

                case "9":
                    Console.WriteLine($"Sum = {memoryList.Sum():F2}");
                    break;

                case "10":
                    if (memoryList.Count > 0)
                        Console.WriteLine($"Average = {memoryList.Average():F2}");
                    else
                        Console.WriteLine("Memory list is empty.");
                    break;

                case "11":
                    if (memoryList.Count >= 2)
                        Console.WriteLine($"Difference = {(memoryList.First() - memoryList.Last()):F2}");
                    else
                        Console.WriteLine("Need at least 2 values to calculate difference.");
                    break;

                case "12":
                    Console.WriteLine("Returning to main menu...\n");
                    return;

                default:
                    Console.WriteLine("Invalid option.\n");
                    break;
            }
        }
    }
}
