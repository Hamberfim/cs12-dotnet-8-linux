using Packt.Shared;

ConfigureConsole();

// alternatives
// ConfigureConsole(useComputerCulture: true);
// ConfigureConsole(culture: "fr-FR");


// Person bob = new Person(); // C# 1or later
// var bob = new Person(); // C# 3 or later

Person bob = new(); // C# 9 or later
WriteLine(bob); // implicit call to ToString method, i.e., WriteLine(bob.ToString());
