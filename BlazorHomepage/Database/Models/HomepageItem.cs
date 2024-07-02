namespace BlazorHomepage.Database.Models;

public class HomepageItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public HomepageItemType Type { get; set; }
    public string? Url { get; set; }
    public string? Description { get; set; }
    public string BackgroundColor { get; set; }
}

public enum HomepageItemType
{
    Link,
    Text
}