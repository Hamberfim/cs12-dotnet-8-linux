using static System.Console;

WriteLine("=== Top Level Functions ===");

WhatsMyNameSpace();// call the function 

// define the local function that is called above
// moved to Program.Functions.cs 
// void WhatsMyNameSpace()
// {
//     WriteLine("Namespace of program class is: {0}", arg0: typeof(Program).Namespace ?? "null");
// }