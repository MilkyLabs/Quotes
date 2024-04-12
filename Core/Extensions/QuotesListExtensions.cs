using System.Collections.Generic;
using System.Linq;
using MilkyLabs.Quotes.Core.Models;


namespace MilkyLabs.Quotes.Core.Extensions;

public static class QuotesListExtensions
{
    public static IEnumerable<Quote> UpdateQuote(this IEnumerable<Quote> quotes, Quote quote)
    {
        return quotes.Where(q => q.Id != quote.Id).Append(quote);
    }
}
