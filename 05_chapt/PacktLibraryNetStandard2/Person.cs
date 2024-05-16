// file scoped namespaced
using System.ComponentModel;

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
}
