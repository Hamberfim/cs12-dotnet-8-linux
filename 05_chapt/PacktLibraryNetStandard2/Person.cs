// file scoped namespaced
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Packt.Shared;

// explicit object inheritance declared
public class Person : object
{
    #region Fields: Data or State of the object

    public string? Name;
    public DateTimeOffset Born;   // date, time, hours offset from UTC (related to time zone)
    public List<Person> Children = new(); // field initialized with an empty List of Person objects
    public WondersOfTheAncientWorld FavoriteAncientWonder; // single enum value
    public WondersOfTheAncientWorld BucketList; // multiple enum values

    public const string Species = "Homo Sapien";  // constant

    public readonly string HomePlanet = "Earth";  // readonly- set at runtime

    public readonly DateTime Instantiated;

    #endregion

    #region Constructor called when using new to initialize a type

    public Person()
    {
        // set default values in the constructor
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    // overloaded constructor
    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    #endregion

    #region Method: an action a type can preform
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on {Born:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }
    #endregion

    #region Define and Pass params to a method of a type
    public string SayHello()
    {
        return $"{Name} says, Hello!";
    }

    public string SayHelloTo(string name)
    {
        return $"{Name} says' Hello, {name}!";
    }

    #endregion

    #region a single method name using overloading

    public string Greetings()
    {
        return $"{Name} says, Greetings!";
    }

    public string Greetings(string name)
    {
        return $"{Name} says' Greetings, {name}!";
    }
    #endregion

    #region methods with optional params
    public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
    {
        return $"The command is {command}, the number is {number}, active is {active}.";
    }
    #endregion

    #region Passing param by value, in (readonly), ref, out
    // Example Call: PassingParamsBy(byValue, inValue, ref refValue, out outValue)
    public void PassingParamsBy(int byValue, in int inValue, ref int refValue, out int outValue)
    {
        // out params can not have a default value and must be initialized in the method
        outValue = 100;

        // increment each param value except the readonly 'inValue'
        byValue++;
        // inValue is readonly //
        refValue++;
        outValue++;

        WriteLine($"In the method byValue = {byValue}, inValue = {inValue}, refValue = {refValue}, outValue = {outValue}");
    }
    #endregion

    #region return multiple values using tuples
    // this method returns a tuple
    public (int, string) GetItemAndItsCount()
    {
        return (5, "Microchips");
    }

    public (int Number, string Name) GetNamedItemAndItsCount()
    {
        return (Number: 20, Name: "Apples");
    }

    #endregion

    #region Deconstructors: Break down an object into its parts
    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }
    public void Deconstruct(out string? name, out DateTimeOffset dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = Born;
        fav = FavoriteAncientWonder;
    }

    #endregion

    #region functionality using local functions

    #endregion
}
