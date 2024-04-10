namespace MilkyLabs.Quotes.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
