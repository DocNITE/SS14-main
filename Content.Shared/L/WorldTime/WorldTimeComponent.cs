using Robust.Shared.GameStates;

namespace Content.Shared.L.WorldTime;

[RegisterComponent, NetworkedComponent]
public sealed partial class WorldTimeComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan TimeLength { get; set; } = TimeSpan.FromMinutes(24);

    [ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan CurrentTime { get; set; } = TimeSpan.FromMinutes(8);

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("dayLightColor")]
    public Color DayLightColor { get; set; } = Color.FromSrgb(Color.White);

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("nightLightColor")]
    public Color NightLightColor { get; set; } = Color.FromHex("#12103c");

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("sunriseLightColor")]
    public Color SunriseLightColor { get; set; } = Color.FromHex("#86687d");

}
