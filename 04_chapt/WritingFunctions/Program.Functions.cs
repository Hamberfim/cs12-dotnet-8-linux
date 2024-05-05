// cultures info
using System.Globalization;


partial class Program
{
    // culture specific config for console
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

    // a times table function
    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"This a the {number} times table with {size} rows.");
        WriteLine();

        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} X {number} = {row * number}");
        }
        WriteLine();
    }

    // value added tax app
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
            _ => 0.07m  // most other states
        };

        return amount * rate;
    }
}