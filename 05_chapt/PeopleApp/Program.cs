
using Packt.Shared;

// console config output
ConfigureConsole();
// alternatives
// ConfigureConsole(useComputerCulture: true);
// ConfigureConsole(culture: "fr-FR");

#region Instantiating a class

// Person bob = new Person(); // C# 1or later
// var bob = new Person(); // C# 3 or later
Person bob = new(); // C# 9 or later
WriteLine(bob + "\n"); // implicit call to ToString method, i.e., WriteLine(bob.ToString());

#endregion

#region Setting and outputting field values

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(year: 1966, month: 4, day: 3, hour: 7, minute: 28, second: 0, offset: TimeSpan.FromHours(-6));  // US Central
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

// children
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

#endregion

#region Setting field values using object initializer syntax | Storing multiple values using an enum type

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

#endregion

#region Making a field static
BankAccount.InterestRate = 0.012m; //store a chared value in static field
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mr. Jones";
jonesAccount.Balance = 2350;
WriteLine($"{jonesAccount.AccountName} earned {(jonesAccount.Balance * BankAccount.InterestRate):C} interest.");

BankAccount smithAccount = new();
smithAccount.AccountName = "Miss Smith";
smithAccount.Balance = 107;
WriteLine($"{smithAccount.AccountName} earned {(smithAccount.Balance * BankAccount.InterestRate):C} interest.");

#endregion

#region Making a field constant

// constant field in Person.cs
WriteLine($"{larry.Name} is a {Person.Species}.");  // accessible by its type

#endregion

#region Making a field readonly
// readonly field in Person.cs
WriteLine($"{bob.Name}  was born on planet {bob.HomePlanet}");  // accessible by its variable

#endregion

#region Making fields required rather than const

/* Required member 'Book.Isbn' must be set in the object initializer or attribute constructor.
   Required member 'Book.Title' must be set in the object initializer or attribute constructor. */
// Book book = new();  //  Error
// Book book = new()
// {
//     // set the two required properties using object initialization
//     Isbn = "978-0000000000",
//     Title = "Some Fictional Book"
// };

// set the other properties
// book.Author = "Sam A Stranger";
// book.PageCount = 299;

// now using the constructors with object initializer syntax
Book book = new(isbn: "978-0000000000", title: "Some Fictional Book")
{
    // the parameter arguments above are required and are set using a decorator [SetsRequiredMembers] via the using statement 'using System.Diagnostics.CodeAnalysis;'
    // the non-require arguments are provided below
    Author = "Sam A Stranger",
    PageCount = 299
};

WriteLine($"\n{book.Isbn}: '{book.Title}' was written by {book.Author} and has {book.PageCount} pages.");

#endregion

#region use the Person.cs constructor

Person blankPerson = new();
WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated}");

// use the overloaded constructor
Person marvin = new(initialName: "Marvin", homePlanet: "Mars");
WriteLine($"{marvin.Name} is from {marvin.HomePlanet} and was created {marvin.Instantiated}");

#endregion

#region Call the Method action a type can preform
bob.WriteToConsole(); // void return method
WriteLine(bob.GetOrigin());  // string return method
#endregion

#region Pass params to a method of a type
WriteLine(bob.SayHello());  //without param arguments
WriteLine(bob.SayHelloTo("Tina"));  // with param arguments
#endregion

#region  single method using overloading
WriteLine(larry.Greetings());
WriteLine(larry.Greetings("Barbara"));
#endregion

#region methods with optional params
WriteLine(larry.OptionalParameters());  // default params used
WriteLine(larry.OptionalParameters("Walk!", 99.7, false));  // passing param arguments
WriteLine(larry.OptionalParameters(number: 52.4, command: "Skip!", active: false));  // passing named param arguments out of order
#endregion

#region Passing param by value, in (readonly), ref, out
int a = 10;
int b = 20;
int c = 30;
int d = 40;

WriteLine($"Before a = {a}, b = {b}, c = {c}, d = {d}");
larry.PassingParamsBy(a, b, ref c, out d);
WriteLine($"After a = {a}, b = {b}, c = {c}, d = {d}");
#endregion

#region return multiple values using tuples
// this method returns a tuple
(int, string) components = larry.GetItemAndItsCount();
WriteLine($"There are {components.Item1} {components.Item2} in stock.");

/* (int Number, string Name) namedFruit = larry.GetNamedItemAndItsCount() can be shortened */
var namedFruit = larry.GetNamedItemAndItsCount();
WriteLine($"There are {namedFruit.Number} {namedFruit.Name} in stock.");
#endregion

#region creating tuples
var aboutBob = (bob.Name, bob.Children.Count);
WriteLine($"{aboutBob.Name} has {aboutBob.Count} children.");
var aboutLarry = (larry.Name, larry.Children.Count);
WriteLine($"{aboutLarry.Name} has {aboutLarry.Count} children.");
#endregion

#region deconstructing a tuple with named fields
(int itemCount, string itemName) = larry.GetNamedItemAndItsCount();
WriteLine($"There are {itemCount} {itemName} available.");
#endregion

#region deconstructing other types using tuples
var (name1, dob1) = bob;  // implicitly calls the deconstruct methods in the Person class
WriteLine($"Deconstructed person: {name1} was born on {dob1}");

var (name2, dob2, fav2) = larry;  // implicitly calls the deconstruct methods in the Person class
WriteLine($"Deconstructed person: {name2} was born in {dob2.Year} and their favorite wonder is {fav2}");
#endregion
