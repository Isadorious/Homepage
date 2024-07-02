namespace BlazorHomepage.Database.Models;

public class BookmarkItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public string Url { get; set; }
    public string? ImageUrl { get; set; }
    public List<string>? Tags { get; set; }
    public int CategoryId { get; set; }
}