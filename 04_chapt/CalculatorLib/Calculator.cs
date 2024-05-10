namespace CalculatorLib;

public class Calculator
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Division(double num1, double num2)
    {
        return num1 / num2; // This will throw an exception if num2 is 0
    }
}
