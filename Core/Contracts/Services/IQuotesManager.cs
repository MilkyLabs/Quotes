using MilkyLabs.Quotes.Core.Models;

namespace MilkyLabs.Quotes.Core.Contracts.Services;

public interface IQuotesManager
{
    Task<IEnumerable<Quote>> Get(Session session);
    Task<IEnumerable<Quote>> Get(FileInfo file);
    Task Save(Session session, IEnumerable<Quote> quotes);
    Task Save(FileInfo file, IEnumerable<Quote> quotes);
}
