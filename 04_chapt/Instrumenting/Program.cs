using System.Diagnostics;  // needed to use Debug and Trace classes

// get the current directory
string currentDir = Environment.CurrentDirectory;
WriteLine($"Current working directory: {currentDir}");

// config a trace listener
string logWritePath = Path.Combine(currentDir, "log.txt");



WriteLine("This is a Console.WriteLine() message");
// messages using the two classes
Debug.WriteLine("This is a Debug.WriteLine() message");
Trace.WriteLine("This is a Trace.WriteLine() message");