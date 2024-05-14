namespace Packt.Shared;

public class Book
{
    // needs .Net 7, C# 11 or later
    public required string? Isbn;
    public required string? Title;

    // below works with any vers .Net
    public string? Author;
    public int PageCount;

}
