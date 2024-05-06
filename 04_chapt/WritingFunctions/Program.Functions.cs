// cultures info
using System.Globalization;

partial class Program
{
    /// <summary>
    /// Prints a times table for a given number.
    /// </summary>
    /// <param name="number">The number to generate the times table for.</param>
    /// <param name="size">The number of rows in the times table. Default is 12.</param>
    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine("=================================================");
        WriteLine($"This a {number} times table with {size} rows.");
        WriteLine();

        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} X {number} = {row * number}");
        }
        WriteLine();
    }

    /// <summary>
    /// Configures the console's output settings.
    /// </summary>
    /// <param name="culture">The culture code to set. Default is "en-US".</param>
    /// <param name="useComputerCulture">Specifies whether to use the computer's culture. Default is false.</param>
    static void ConfigConsole(string culture = "en-US", bool useComputerCulture = false)
    {
        // enable Unicode characters
        OutputEncoding = System.Text.Encoding.UTF8;
        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        WriteLine($"Current Culture Setting: {CultureInfo.CurrentCulture.DisplayName}");
    }

    /// <summary>
    /// Calculates the value added tax (VAT) tax amount for a given amount and region code.
    /// </summary>
    /// <param name="amount">The amount to calculate the VAT tax for.</param>
    /// <param name="regionCode">The region code to determine the VAT tax rate. Valid region codes are "CH", "DK", "NO", "GB", "FR", "HU", "OR", "AK", "MT", "ND", "WI", "ME", "VA", and "CA".</param>
    /// <returns>The VAT tax amount.</returns>
    static decimal CalculateVatTax(decimal amount, string regionCode)
    {
        // switch expression
        decimal rate = regionCode switch
        {
            "CH" => 0.08m, // Switzerland
            "DK" or "NO" => 0.25m, // Denmark/Norway
            "GB" or "FR" => 0.2m, // UK/France
            "HU" => 0.27m,  // Hungary
            "OR" or "AK" or "MT" => 0.0m, // Oregon/Alaska/Montana
            "ND" or "WI" or "ME" or "VA" => 0.5m, // N.Dakota/Wisconsin/Main/Virginia
            "CA" => 0.0825m, //California
            _ => 0.07m  // most other states - default in a switch expression
        };

        return amount * rate;
    }

    /// <summary>
    /// Converts a cardinal number to its ordinal representation.
    /// </summary>
    /// <param name="number">The cardinal number to convert.</param>
    /// <returns>The ordinal representation of the number.</returns>
    static string CardinalToOrdinal(uint number)
    {
        uint lastTwoDigits = number % 100;

        switch (lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number}th";
            default:
                uint lastDigit = number % 10;

                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };

                return $"{number:N0}{suffix}";
        }
    }

    /// <summary>
    /// Runs the CardinalToOrdinal function for numbers 1 to 150 and prints the results.
    /// </summary>
    static void RunCardinalToOrdinal()
    {
        for (uint number = 1; number <= 150; number++)
        {
            Write($"{CardinalToOrdinal(number)} ");
        }
        WriteLine();
    }

    /// <summary>
    /// Calculates the factorial of a given number.
    /// </summary>
    /// <param name="number">The number to calculate the factorial for.</param>
    /// <returns>The factorial of the given number.</returns>
    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(message: $"Factorial Function can not uses negative numbers. {number} is invalid.", paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked // for overflow
            {
                return number * Factorial(number - 1);
            }
        }
    }

    /// <summary>
    /// Runs the factorial calculation for a range of numbers and displays the results.
    /// </summary>
    static void RunFactorial()
    {
        for (int i = -2; i <= 15; i++)
        {
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is too big for a 32-bit integer.");
            }
            catch (Exception ex)
            {
                WriteLine($"{i} throws {ex.GetType()}: {ex.Message}");
            }

        }
    }
}