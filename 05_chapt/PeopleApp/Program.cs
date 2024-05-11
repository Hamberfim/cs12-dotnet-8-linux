using Packt.Shared;

ConfigureConsole();

// alternatives
// ConfigureConsole(useComputerCulture: true);
// ConfigureConsole(culture: "fr-FR");


// Person bob = new Person(); // C# 1or later
// var bob = new Person(); // C# 3 or later

Person bob = new(); // C# 9 or later
WriteLine(bob + "\n"); // implicit call to ToString method, i.e., WriteLine(bob.ToString());

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(year: 1966, month: 4, day: 3, hour: 7, minute: 28, second: 0, offset: TimeSpan.FromHours(-6));  // US Central

WriteLine($"Format: {bob.Name} was born on {bob.Born}");

// using object initializer syntax
Person larry = new()
{
    Name = "Larry Smith",
    Born = new DateTimeOffset(year: 1997, month: 3, day: 7, hour: 11, minute: 28, second: 0, offset: TimeSpan.Zero)
};
WriteLine($"Format: {larry.Name} was born on {larry.Born}");