using static System.Console;

// no namespace defined so that this class goes into the default empty namespace

partial class Program
{
    static void WhatsMyNameSpace()
    {
        WriteLine("Namespace of program class is: {0}\n", arg0: typeof(Program).Namespace ?? "null\n");
    }
}