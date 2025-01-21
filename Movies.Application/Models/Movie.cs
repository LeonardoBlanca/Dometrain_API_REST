using System.Text.RegularExpressions;

namespace Movies.Application.Models;

public partial class Movie
{
    public required Guid Id { get; init; }
    
    public string Title { get; set; }

    public string Slug => GenerateSlug();

    public int YearOfRelease { get; set; }
    
    public List<string> Genres { get; init; } = new();
    
    private string GenerateSlug()
    {
        var sluggetTitle = SlugReged().Replace(Title, String.Empty)
            .ToLower().Replace(" ", "-");
        return $"{sluggetTitle}-{YearOfRelease}";
    }

    [GeneratedRegex("[^0-9A-Za-z _-]", RegexOptions.NonBacktracking, 5)]
    private static partial Regex SlugReged();
}