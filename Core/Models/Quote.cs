using System;

namespace MilkyLabs.Quotes.Core.Models;

public class Quote
{
    private string _text;
    private string _author;
    private string _source;

    public string Id { get; set; }
    public string Text
    {
        get => _text; 
        set
        {
            _text = value;
            LastUpdated = DateTime.Now;
        }
    }
    public DateTime LastUpdated { get; set; }
    public DateTime Creation { get; set; }
    public string Author
    {
        get => _author; 
        set
        {
            _author = value;
            LastUpdated = DateTime.Now;
        }
    }
    public string Source
    {
        get => _source; 
        set
        {
            _source = value;
            LastUpdated = DateTime.Now;
        }
    }
    public static Quote Create(string text) => 
        new()
        {
            Id = Guid.NewGuid().ToString(), 
            Text= text,
            Creation = DateTime.Now,
            LastUpdated = DateTime.Now
        };

}
