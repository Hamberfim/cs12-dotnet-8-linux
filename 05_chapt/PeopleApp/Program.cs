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
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

// 
Person tammi = new Person();
tammi.Name = "Tammi Smith";
bob.Children.Add(tammi);

Person kyle = new Person();
kyle.Name = "Kyle Smith";
bob.Children.Add(kyle);

// using string interpolation
WriteLine($"{bob.Name} was born on {bob.Born}. {bob.Name}'s favorite ancient wonder is {bob.FavoriteAncientWonder}.");
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");
WriteLine($"{bob.Name} has {bob.Children.Count} children.");
foreach (Person child in bob.Children)
{
    WriteLine($"{bob.Name}'s Child: {child.Name}");
}

// using object initializer syntax
Person larry = new()
{
    Name = "Larry Smith",
    Born = new DateTimeOffset(year: 1997, month: 3, day: 7, hour: 11, minute: 28, second: 0, offset: TimeSpan.Zero),
    FavoriteAncientWonder = WondersOfTheAncientWorld.MausoleumAtHalicarnassus,
    Children = new List<Person> { new() { Name = "Mary Smith" }, new() { Name = "Lidia Smith" }, new() { Name = "Peter Smith" } }, // Modify code to use the Add method
    BucketList = WondersOfTheAncientWorld.GreatPyramidOfGiza | WondersOfTheAncientWorld.HangingGardensOfBabylon
};
WriteLine($"\n{larry.Name} was born on {larry.Born}. {larry.Name}'s favorite ancient wonder is {larry.FavoriteAncientWonder}.");
WriteLine($"{larry.Name}'s bucket list is {larry.BucketList}.");
WriteLine($"{larry.Name} has {larry.Children.Count} children.");
for (int i = 0; i < larry.Children.Count; i++)
{
    WriteLine($"{larry.Name}'s Child: {larry.Children[i].Name}");
}
WriteLine(); // space in output