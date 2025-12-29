namespace EcoQuest.Domain.ValueObjects;

public readonly record struct UserId
{
    #region Properties
    public string Value { get; }
    #endregion

    #region Constructors
    private UserId(string value)
    {
        if (String.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("UserId can not be empty", nameof(value));
        }

        Value = value;
    }

    public UserId() => Value = string.Empty; // Utilisé uniquement par EF
    #endregion

    #region Methods
    public static UserId Create(string value)
    {
        return new UserId(value);
    }

    public override string ToString()
    {
        return Value;
    }
    #endregion
}