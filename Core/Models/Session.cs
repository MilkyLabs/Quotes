using System.IO;

namespace MilkyLabs.Quotes.Core.Models;

public record Session(FileInfo CurrentFile, IEnumerable<FileInfo> History);
