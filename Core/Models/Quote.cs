using System;

namespace MilkyLabs.Quotes.Core.Models;

public class Quote
{
    public string Id { get; set; }
    public string Text { get; set; }
    public DateTime LastUpdated { get; set; }
    public DateTime Creation { get; set; }
    public string Author { get; set; }
    public string Source { get; set; }
    Quote SetText(string text) => this with { Text = text, LastUpdated = DateTime.Now };
    Quote SetAuthor(string author) => this with { Author = author, LastUpdated = DateTime.Now };
    Quote SetSource(string source) => this with { Source = source, LastUpdated = DateTime.Now };
    public static Quote Create(string text) => 
        new Quote
        {
            Id = Guid.NewGuid().ToString(), 
            Text= text,
            Creation = DateTime.Now,
            LastUpdated = DateTime.Now
        };

}
