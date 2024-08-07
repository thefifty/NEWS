namespace Core;

public class InvalidAmountException : BadRequestException
{
    public decimal Amount { get; }

    public InvalidAmountException(decimal amount)
        : base($"Amount: '{amount}' is invalid.")
    {
        Amount = amount;
    }
}
