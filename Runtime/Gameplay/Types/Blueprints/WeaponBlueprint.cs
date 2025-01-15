using BIG;
using Photon.Deterministic;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types
{
    [Preserve]
    public sealed class WeaponBlueprint : Blueprint
    {
        [Preserve] public WeaponType WeaponType { get; set; }
        [Preserve] public FP MinDamageRawValue { get; set; }
        [Preserve] public FP MaxDamage { get; set; }
        [Preserve] public FP ReloadTime { get; set; }
        [Preserve] public FP EnergyCost { get; set; }
        [Preserve] public FP Range { get; set; }
    }
}
