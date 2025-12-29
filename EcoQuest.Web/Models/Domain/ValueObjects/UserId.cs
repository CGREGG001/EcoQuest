namespace EcoQuest.Domain.ValueObjects;

/// <summary>
/// Identifiant fort typé représentant un utilisateur.
/// Value Object immuable conforme au modèle DDD.
/// </summary>
public readonly record struct UserId
{
    #region Properties
    /// <summary>
    /// Valeur brute de l’identifiant utilisateur (généralement un GUID).
    /// </summary>
    public string Value { get; }
    #endregion

    #region Constructors
    /// <summary>
    /// Constructeur métier privé.
    /// Utiliser <see cref="Create"/> pour instancier un identifiant valide.
    /// </summary>
    private UserId(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("UserId can not be empty", nameof(value));
        }

        Value = value;
    }

    /// <summary>
    /// Constructeur requis par EF Core pour l’hydratation.
    /// Ne doit jamais être utilisé dans le domaine.
    /// </summary>
    public UserId() => Value = string.Empty;
    #endregion

    #region Methods
    /// <summary>
    /// Crée un identifiant utilisateur valide.
    /// </summary>
    public static UserId Create(string value) => new(value);

    public override string ToString() => Value;
    #endregion
}