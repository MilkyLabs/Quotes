namespace MilkyLabs.Quotes.Core.Contracts.Services;

public interface IFileDataManager
{
    Task<T> ParseFile<T>(FileInfo file);
    Task WriteFile<T>(FileInfo file, T data);
}