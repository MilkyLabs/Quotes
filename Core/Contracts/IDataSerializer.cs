namespace MilkyLabs.Quotes.Core.Contracts;

public interface IDataSerializer
{
    Task<string> Serialize<T>( T data);
    Task<T> Deserialize<T>(string text);
}