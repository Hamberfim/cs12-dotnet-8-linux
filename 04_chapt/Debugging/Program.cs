
// double a = 4.5;
// double b = 2.5;
// double c = Add(a, b);  // should return 7

// WriteLine($"The sum of {a} and {b} is {c}");
// WriteLine("Press Enter to exit...");
// ReadLine();

WriteLine("Enter a number: ");
string number1 = ReadLine()!;  // possible null value
WriteLine("Enter another number: ");
string number2 = ReadLine()!;  // possible null value

try
{
    double a = double.Parse(number1);
    double b = double.Parse(number2);
    double c = Add(a, b);
    WriteLine($"The sum of {a} and {b} is {c}");
    WriteLine("Press Enter to exit...");
    ReadLine();
}
catch (Exception ex)
{
    WriteLine($"An error occurred: {ex.Message}");
    WriteLine("Press Enter to exit...");
    ReadLine();
}

// deliberate bug in function
double Add(double a, double b)
{
    return a + b;  // deliberate bug
}

