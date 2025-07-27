class InputValidator
{
    public static int ReadInt(string prompt)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();

        while (!int.TryParse(input, out int result))
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
            input = Console.ReadLine();
        }

        return int.Parse(input!);
    }


    public static double ReadDouble(string prompt)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();

        while (!double.TryParse(input, out double result))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
            input = Console.ReadLine();
        }

        return double.Parse(input!);
    }


    public static int ReadMenuChoice(string prompt)
    {
        int result;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
        }
        return result;
    }

    public static int[] ReadIntList(string prompt)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        return input?.Split(' ')
                    .Where(s => int.TryParse(s, out _))
                    .Select(int.Parse)
                    .ToArray() ?? Array.Empty<int>();
    }


    public static double[] ReadDoubleList(string prompt)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        return input?.Split(' ')
                    .Where(s => double.TryParse(s, out _))
                    .Select(double.Parse)
                    .ToArray() ?? Array.Empty<double>();
    }

}