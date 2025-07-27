class Calculator
{
  public static int Add(int a, int b)
  {
    return a + b;
  }

  public static int Subtract(int a, int b)
  {
    return a - b;
  }

  public static int Multiply(int a, int b)
  {
    return a * b;
  }

  public static double Divide(double a, double b)
  {
    if (b == 0)
      throw new Exception("Division by zero is not allowed.");
    return a / b;
  }

  public static int Modulus(int a, int b)
  {
      if (b == 0)
      {
          throw new Exception("ivision by zero is not allowed.");
      }
      return a % b;
  }

  public static int Add(int[] numbers)
  {
      int sum = 0;
      foreach (int num in numbers)
          sum += num;
      return sum;
  }

  public static int Subtract(int[] numbers)
  {
      if (numbers.Length == 0) return 0;
      int result = numbers[0];
      for (int i = 1; i < numbers.Length; i++)
          result -= numbers[i];
      return result;
  }

  public static int Multiply(int[] numbers)
  {
      if (numbers.Length == 0) return 0;
      int result = 1;
      foreach (int num in numbers)
          result *= num;
      return result;
  }

  public static double Divide(double[] numbers)
  {
      if (numbers.Length == 0) return 0;
      double result = numbers[0];
      for (int i = 1; i < numbers.Length; i++)
      {
          if (numbers[i] == 0)
              throw new Exception("Division by zero is not allowed.");
          result /= numbers[i];
      }
      return result;
  }
}
