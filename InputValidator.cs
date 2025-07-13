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
    Console.Write(prompt);
    while (!double.TryParse(Console.ReadLine(), out result))
    {
      Console.Write("Invalid input. Please enter a valid decimal number: ");
    }
    return result;
  }
  public static int ReadMenuChoice(string choice)
    {
        int result;
        Console.Write(choice);
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
        }
        return result;
    }
}
