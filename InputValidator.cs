class InputValidator
{
    public static int ReadInt(string prompt)
    {
        int result;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
        }
        return result;
    }

    public static double ReadDouble(string prompt)
    {
        double result;
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            try
            {
                result = Convert.ToDouble(input);
                return result;
            }
            catch (FormatException)
            {
                Console.WriteLine("Input string was not in the correct format. Please enter a valid number.");
            }
        }
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
}