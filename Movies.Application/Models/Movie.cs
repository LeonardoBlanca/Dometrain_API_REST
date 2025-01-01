namespace Movies.Application.Models;

public class Movie
{
    public required Guid Id { get; init; }
    
    public string Title { get; set; }
    
    public int YearOfRelease { get; set; }
    
    public List<string> Genres { get; init; } = new();
}