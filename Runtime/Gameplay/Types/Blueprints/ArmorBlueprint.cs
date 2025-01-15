using BIG;
using Photon.Deterministic;

namespace SpaceSmuggler.Gameplay.Types
{
    [Preserve]
    public sealed class ArmorBlueprint : Blueprint 
    {
        [Preserve] public FP Armor { get; set; }
    }
}
