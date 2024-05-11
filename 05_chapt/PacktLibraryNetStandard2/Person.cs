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

    #endregion
}
