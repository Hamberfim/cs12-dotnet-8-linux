// file scoped namespaced
using System.ComponentModel;

namespace Packt.Shared;

// explicit object inheritance declared
public class Person : object
{
    #region Fields: Data or State of the object

    public string? Name;
    public DateTimeOffset Born;   // date, time, hours offset from UTC (related to time zone)
    public WondersOfTheAncientWorld FavoriteAncientWonder;

    #endregion
}
