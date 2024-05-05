
/* at prompt:> dotnet run firstarg second-arg third:arg "fourth arg" */

// output the number of arguments passed to main
WriteLine($"There are {args.Length} arguments passed to Main().");

// loop through the passed in args
foreach (string arg in args)
{
    WriteLine(arg);
}

// setting options with argument
if (args.Length < 3)
{
    WriteLine("You must specify two colors and a cursor size, e.g.");
    WriteLine("dotnet run red yellow 50");
    return; // stop running
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0], ignoreCase: true
);

BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1], ignoreCase: true
);

// 'Console.CursorSize.set' is only supported on: 'windows'.
try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current OS/Platform doesn't support changing the size of the cursor.");
}

// using operating systems class as platform guard methods
if (OperatingSystem.IsWindows())
{
    CursorSize = int.Parse(args[2]);
}
else if (OperatingSystem.IsLinux())
{
    WriteLine("The linux OS doesn't support changing the size of the cursor.");
}