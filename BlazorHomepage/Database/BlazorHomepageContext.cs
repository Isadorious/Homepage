using BlazorHomepage.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorHomepage.Database;

public class BlazorHomepageContext : DbContext
{
    public DbSet<HomepageItem> HomepageItems { get; set; }
    public DbSet<BookmarkItem> BookmarkItems { get; set; }
    public DbSet<BookmarkCategory> BookmarkCategories { get; set; }
    
    public string DbPath { get; set; }

    public BlazorHomepageContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "BlazorHomepage.db");
    }
    
    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    
    #region Required

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HomepageItem>().ToTable("HomepageItems");
        modelBuilder.Entity<BookmarkItem>().ToTable("BookmarkItems");
        modelBuilder.Entity<BookmarkCategory>().ToTable("BookmarkCategories");
        
    }
    #endregion
}