namespace Core;

public record PhoneNumber
{
    // EF
    private PhoneNumber(string value)
    {
        Value = value;
    }

    // Note: in entities with none default constructor, for setting constructor parameter, we need a private set property
    // when we didn't define this property in fluent configuration mapping (if so we can remove private set) , because for getting mapping list of properties to set
    // in the constructor it should not be read only without set (for bypassing calculate fields)- https://learn.microsoft.com/en-us/ef/core/modeling/constructors#read-only-properties
    public string Value { get; private set; } = default!;

    public static PhoneNumber Of(string value)
    {
        if (value.IsEmpty()) return null;
        return new PhoneNumber(value);
    }

    public void Validate(string value)
        => Guard.Against.InvalidPhoneNumber(value, new DomainException($"Phone number {value} is invalid."));

    public static implicit operator string(PhoneNumber phoneNumber) => phoneNumber.Value;
}
