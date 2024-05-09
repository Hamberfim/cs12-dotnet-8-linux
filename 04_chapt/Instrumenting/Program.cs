using System.Diagnostics;  // needed to use Debug and Trace classes

/* config a trace listener */
// get the current directory
string currentDir = Environment.CurrentDirectory;
WriteLine($"Current working directory: {currentDir}");

/* if you want to direct the output file to the desktop, you can use the following code:
string desktopDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "log.txt");
*/
// path and file name that I am writing to
string logWritePath = Path.Combine(currentDir, "log.txt");

// write log path to console
WriteLine($"Write Log file path: {logWritePath}");

TextWriterTraceListener logFile = new(File.CreateText(logWritePath)); // create a new file
Trace.Listeners.Add(logFile); // add the file to the trace listeners

#if DEBUG
/* Text writer is buffered, so you need to call Flush() on all the listeners after writing to the file */
// use during debugging and development but NOT IN PRODUCTION
Trace.AutoFlush = true; // flushes the output buffer after each write
#endif

// will display in Console
WriteLine("This is a Console.WriteLine() message");
// messages using the two classes below will not display in the console, but in the debug output window
Debug.WriteLine("This is a Debug.WriteLine() message");
Trace.WriteLine("This is a Trace.WriteLine() message");

// flush and close any buffered trace listeners for Debug and Trace
// Debug.close();
// Trace.close();
logFile.Close(); // close the log file

// run in the terminal: dotnet run --configuration Release
// run in the terminal: dotnet run --configuration Debug