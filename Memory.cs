using System;
using System.Collections.Generic;
using System.Linq;
public class Memory
{
    private double? memoryValue = null;
    private List<int> memoryList = new List<int>();

    // Use InputValidator for input validation

    public void ShowMemoryMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMemory Menu:");
            Console.WriteLine("1. Store single value");
            Console.WriteLine("2. Retrieve single value");
            Console.WriteLine("3. Clear single value");
            Console.WriteLine("4. Replace single value");
            Console.WriteLine("5. Add value to memory list");
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
                    Console.WriteLine(memoryValue.HasValue ? $"Stored value: {memoryValue}" : "No value in memory.");
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
                    }
                    else
                    {
                        int val = InputValidator.ReadInt("Enter integer to add: ");
                        memoryList.Add(val);
                        Console.WriteLine("Value added.");
                    }
                    break;

                case "6":
                    if (memoryList.Count == 0)
                        Console.WriteLine("Memory list is empty.");
                    else
                        Console.WriteLine("Values: " + string.Join(", ", memoryList));
                    break;

                case "7":
                    Console.WriteLine($"Count: {memoryList.Count}");
                    break;

                case "8":
                    int removeVal = InputValidator.ReadInt("Enter value to remove: ");
                    if (memoryList.Remove(removeVal))
                        Console.WriteLine("Value removed.");
                    else
                        Console.WriteLine("Value not found.");
                    break;

                case "9":
                    int sum = 0;
                    foreach (var num in memoryList) sum += num;
                    Console.WriteLine($"Sum: {sum}");
                    break;

                case "10":
                    if (memoryList.Count == 0)
                        Console.WriteLine("No values to average.");
                    else
                        Console.WriteLine($"Average: {(double)memoryList.Sum() / memoryList.Count}");
                    break;

                case "11":
                    if (memoryList.Count < 2)
                        Console.WriteLine("Need at least two values.");
                    else
                        Console.WriteLine($"Difference: {memoryList[0] - memoryList[^1]}");
                    break;

                case "12":
                    Console.WriteLine("Exiting Memory Menu...");
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
