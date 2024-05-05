
// int someCount = int.Parse("Hello");  // throws unhandled error

bool isSuccess = int.TryParse("Hello", out int count);  // any error is silent
WriteLine($"count is: {count} <-- 0=false");

if (isSuccess)
{
    WriteLine($"The string converted: {count}");
}
else
{
    WriteLine($"The string converted: {isSuccess.ToString()}");
}

isSuccess = int.TryParse("123", out int count2);
WriteLine($"count2 is: {count2} <-- 1=true");

if (isSuccess)
{
    WriteLine($"The string converted: {count2}");
}
else
{
    WriteLine($"The string converted: {isSuccess.ToString()}");
}

// specific exceptions
try
{
    int age = int.Parse("abc");
}
catch (FormatException error)
{
    WriteLine($"{error.Message} Input is not a number.");
}

// catch all exceptions
string[] names = { "Tom", "Linda" }; // index has 0, 1 in total
try
{
    // double price = double.Parse("Twenty-Dollars");
    WriteLine(names[2]);

}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}

// catch filters 
string amount = "$12.99";

try
{
    double price = double.Parse(amount);
    WriteLine($"${price}");

}
catch (Exception ex) when (amount.Contains("$"))
{
    WriteLine("Amount can not contain the dollar sign.");
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
catch (Exception ex)
{
    WriteLine("Amount can only contain numbers.");
    WriteLine($"{ex.GetType()} says {ex.Message}");
}