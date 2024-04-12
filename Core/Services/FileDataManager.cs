using MilkyLabs.Quotes.Core.Contracts;
using MilkyLabs.Quotes.Core.Contracts.Services;
using MilkyLabs.Quotes.Core.DataSerializers;

namespace MilkyLabs.Quotes.Core.Services;

public class FileDataManager : IFileDataManager
{
    public async Task<T> ParseFile<T>(FileInfo file)
    {
        var text = await File.ReadAllText(file.FullName);
        return await GetSerializer(file).Deserialize<T>(text);
    }

    public async Task WriteFile<T>(FileInfo file, T data)
    {
        var text = await GetSerializer(file).Serialize(data);
        await File.WriteAllTextAsync(file.FullName, text);
    }

    private IDataSerializer GetSerializer(FileInfo file)
    {
        return file.Extension.ToLower() switch
        {
            ".json" => new JsonDataSerializer(),
            _ => new JsonDataSerializer(),
        };
    }
}