// using static System.Console;  // simplify Console.WriteLine(); moved to .csproj file

internal class Program
{
    private static void Main(string[] args)
    {
        // user input
        WriteLine("Enter your first name: ");
        string? fName = ReadLine();

        WriteLine("Enter your age: ");
        string? age = ReadLine();

        if (string.IsNullOrEmpty(fName) && string.IsNullOrEmpty(age))
        {
            WriteLine($"Hi,hope you have a great day on your next birthday.");
        }
        else if (!string.IsNullOrEmpty(fName) && string.IsNullOrEmpty(age))
        {
            WriteLine($"Hi {fName}, hope you have a great day on your next birthday.");
        }
        else if (string.IsNullOrEmpty(fName) && !string.IsNullOrEmpty(age))
        {
            WriteLine($"Hi, you are going to be {Convert.ToInt32(age) + 1} on your next birthday.");
        }
        else
        {
            WriteLine($"Hi {fName}, you are going to be {Convert.ToInt32(age) + 1} on your next birthday.");
        }

        // getting key press input
        WriteLine("Press any key combination: ");
        ConsoleKeyInfo key = ReadKey();
        WriteLine();  // space in out put
        //WriteLine("Key: {0}, char: {1}, Modifiers: {2}", arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);
        WriteLine($"Key: {key.Key}, char: {key.KeyChar}, Modifiers: {key.Modifiers}");
    }
}