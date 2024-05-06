using static System.Console;

// no namespace defined so that this class goes into the default empty namespace

// just like the auto-generated partial Program class
partial class Program
{ // define a static function    static void WhatsMyNameSpace()
    static void WhatsMyNameSpace()
    {
        WriteLine("Namespace of program class is: {0}\n", arg0: typeof(Program).Namespace ?? "null\n");
    }
}