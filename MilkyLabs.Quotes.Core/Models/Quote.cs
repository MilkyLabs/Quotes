using System;

namespace MilkyLabs.Quotes.Core.Models;

public record class Quote(string Text, DateTime LastUpdated, DateTime Creation, string? Author = null, string? Source = null)
{
    Quote SetText(string text) => this with { Text = text, LastUpdated = DateTime.Now }
    Quote SetAuthor(string author) => this with { Author = author, LastUpdated = DateTime.Now };
    public static Quote Create(string Text) => new Quote(Text, DateTime.Now, DateTime.Now);
}
