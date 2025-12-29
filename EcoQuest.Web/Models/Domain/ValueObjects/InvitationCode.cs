namespace EcoQuest.Domain.ValueObjects;

public readonly record struct InvitationCode
{
    #region Properties
    public string Value { get; }
    #endregion

    #region Constructors
    private InvitationCode(string value)
    {
        if (String.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Invitation code can not be empty", nameof(value));
        }

        if (value.Length != 8)
        {
            throw new ArgumentException("Invitation code must be 8 characters long", nameof(value));
        }

        Value = value;
    }

    public InvitationCode() { Value = string.Empty; } // utilisé uniquement par EF
    #endregion

    #region Methods
    public static InvitationCode Create(string value)
    {
        return new InvitationCode(value);
    }

    public override string ToString()
    {
        return Value;
    }
    #endregion
}