// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, C#!");

// get name of the namespace of the Program.cs class
string name = typeof(Program).Namespace ?? "None!";
Console.WriteLine($"Namespace: {name}");
throw new Exception();