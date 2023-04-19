using Robust.Shared.Prototypes;

namespace Content.Shared.Roles;
/// <summary>
///     Describes information for a species whitelist
/// </summary>
[Prototype("jobWhitelist")]
public sealed class JobWhitelistPrototype : IPrototype
{
    [IdDataField] public string ID { get; } = default!;
    /// <summary>
    ///  Job ID, where we wanna spawn specific characters with them race
    /// </summary>
    [DataField("job", required: true)]
    public string Job { get; } = default!;
    [DataField("species")]
    public IReadOnlyCollection<string> Species { get; } = Array.Empty<string>();
}
