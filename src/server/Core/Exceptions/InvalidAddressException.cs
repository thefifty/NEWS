namespace Core;

public class InvalidAddressException : BadRequestException
{
    public string Address { get; }

    public InvalidAddressException(string address)
        : base($"Address: '{address}' is invalid.")
    {
        Address = address;
    }
}
