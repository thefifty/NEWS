namespace Core;

public class InvalidPhoneNumberException : BadRequestException
{
    public string PhoneNumber { get; }

    public InvalidPhoneNumberException(string phoneNumber)
        : base($"PhoneNumber: '{phoneNumber}' is invalid.")
    {
        PhoneNumber = phoneNumber;
    }
}
