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
}
