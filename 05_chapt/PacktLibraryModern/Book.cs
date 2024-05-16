using System.Diagnostics.CodeAnalysis; // adds the ability to use [SetsRequiredMembers]
namespace Packt.Shared;

public class Book
{
    // needs .Net 7, C# 11 or later
    public required string? Isbn;
    public required string? Title;

    // below works with any vers .Net
    public string? Author;
    public int PageCount;

    // default constructor for use with object initializer syntax
    public Book() { }

    // constructor with parameters to set required fields
    [SetsRequiredMembers]
    public Book(string? isbn, string? title)
    {
        Isbn = isbn;
        Title = title;
    }

}
