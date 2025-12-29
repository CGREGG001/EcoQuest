namespace EcoQuest.Domain.ValueObjects;

/// <summary>
/// Représente un code d’invitation unique utilisé pour rejoindre un groupe.
/// Value Object immuable conforme au modèle DDD.
/// </summary>
public readonly record struct InvitationCode
{
    #region Properties
    /// <summary>
    /// Valeur brute du code d’invitation.
    /// Toujours une chaîne non vide de 8 caractères.
    /// </summary>
    public string Value { get; }
    #endregion

    #region Constructors
    /// <summary>
    /// Constructeur métier privé.
    /// Utiliser <see cref="Create"/> pour instancier un code valide.
    /// </summary>
    private InvitationCode(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Invitation code can not be empty", nameof(value));
        }

        if (value.Length != 8)
        {
            throw new ArgumentException("Invitation code must be 8 characters long", nameof(value));
        }

        Value = value;
    }

    /// <summary>
    /// Constructeur requis par EF Core pour l’hydratation.
    /// Ne doit jamais être utilisé dans le domaine.
    /// </summary>
    public InvitationCode() => Value = string.Empty;
    #endregion

    #region Methods
    /// <summary>
    /// Crée un code d’invitation valide.
    /// </summary>
    public static InvitationCode Create(string value) => new(value);

    public override string ToString() => Value;
    #endregion
}