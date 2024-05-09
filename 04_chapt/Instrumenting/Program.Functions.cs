using System.Diagnostics;
using System.Runtime.CompilerServices;  // to user Caller...

// log information about the source code
partial class Program
{
    static void LogSourceDetails(
        bool condition,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0,
        [CallerArgumentExpression(nameof(condition))] string conditionExpression = "")
        {
            Trace.WriteLine($"[{filePath}]\n {memberName} on line {lineNumber}. Expression: {conditionExpression}");
        }
}
    