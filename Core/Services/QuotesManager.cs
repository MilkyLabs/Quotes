using MilkyLabs.Quotes.Core.Contracts.Services;
using MilkyLabs.Quotes.Core.Models;

namespace MilkyLabs.Quotes.Core.Services;

public class QuotesManager : IQuotesManager
{
    private readonly IFileDataManager _fileDataManager;

    public QuotesManager(IFileDataManager fileDataManager)
    {
        _fileDataManager = fileDataManager;
    }
    public Task<IEnumerable<Quote>> Get(Session session)
    {
        return Get(session.CurrentFile);
    }
    public Task<IEnumerable<Quote>> Get(FileInfo file)
    {
        return _fileDataManager.ParseFile<IEnumerable<Quote>>(file);
    }
    public Task Save(Session session, IEnumerable<Quote> quotes)
    {
        return Save(session.CurrentFile, quotes);
    }
    public Task Save(FileInfo file, IEnumerable<Quote> quotes)
    {
        return _fileDataManager.WriteFile(file, quotes);
    }
}
