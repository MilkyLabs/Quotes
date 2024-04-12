using MilkyLabs.Quotes.Core.Contracts;
using Newtonsoft.Json;

namespace MilkyLabs.Quotes.Core.DataSerializers;

public class JsonDataSerializer : IDataSerializer
{
    public async Task<string> Serialize<T>( T data)
    {
        var result = JsonConvert.SerializeObject(data);
    }

    public async Task<T> Deserialize<T>(string text)
    {
        return JsonConvert.DeserializeObject<T>(text);
    }
}