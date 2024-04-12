using System;

namespace MilkyLabs.Quotes.Core.Models;

public record Quote(string Id, string Text, DateTime LastUpdated, DateTime Creation, string? Author = null, string? Source = null)
{
    Quote SetText(string text) => this with { Text = text, LastUpdated = DateTime.Now };
    Quote SetAuthor(string author) => this with { Author = author, LastUpdated = DateTime.Now };
    Quote SetSource(string source) => this with { Source = source, LastUpdated = DateTime.Now };
    public static Quote Create(string text) => 
        new Quote(Guid.NewGuid().ToString(), text, DateTime.Now, DateTime.Now);
}
