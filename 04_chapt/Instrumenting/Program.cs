using System.Diagnostics;  // needed to use Debug and Trace classes
using Microsoft.Extensions.Configuration; // to use ConfigurationBuilder

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

// create a configuration builder to look for the appsettings.json file
string settingsFile = "appsettings.json";
string settingsPath = Path.Combine(currentDir, settingsFile);
WriteLine($"Processing: {settingsPath}");
WriteLine($"--{settingsFile}");
WriteLine(File.ReadAllText(settingsPath));
WriteLine("----");

ConfigurationBuilder builder = new();

builder.SetBasePath(currentDir);
/* add the appsettings.json file to the configuration builder, 
making it mandatory so an exception will be thrown if the the file is not found */
builder.AddJsonFile(settingsFile, optional: false, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build(); // build the configuration

TraceSwitch traceSwitch = new(displayName: "PacktSwitch", description: "This switch is set via the appsettings.json config file");
configuration.GetSection("PacktSwitch").Bind(traceSwitch); // bind the configuration to the trace switch

WriteLine($"Trace Switch Value: {traceSwitch.Value}"); // write the trace switch value to the console
WriteLine($"Trace Switch Level: {traceSwitch.Level}"); // write the trace switch level to the console

Trace.WriteLineIf(traceSwitch.TraceError, "A Trace Error message");
Trace.WriteLineIf(traceSwitch.TraceWarning, "A Trace Warning message");
Trace.WriteLineIf(traceSwitch.TraceInfo, "A Trace Info message");
Trace.WriteLineIf(traceSwitch.TraceVerbose, "A Trace Verbose message");

// for source code logging
int x = 3;
LogSourceDetails(x > 2);  // will write to the log file

// flush and close any buffered trace listeners for Debug and Trace
// Debug.close();  // error Debug does not contain a definition for close
// Trace.close();  // error Trace does not contain a definition for close
logFile.Close(); // close the log file

// run in the terminal: dotnet run --configuration Release
// run in the terminal: dotnet run --configuration Debug

/* adding NuGet packages:
dotnet add package Microsoft.Extensions.Configuration.Binder
dotnet add package Microsoft.Extensions.Configuration.Json
*/
WriteLine("Press any key to exit");
ReadLine();