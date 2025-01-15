using BIG;
using Photon.Deterministic;

namespace SpaceSmuggler.Gameplay.Types
{
    [Preserve]
    public sealed class ShieldBlueprint : Blueprint
    {
        /// <summary>
        /// Max shield points.
        /// </summary>
        [Preserve] public FP ShieldPoints { get; set; }

        /// <summary>
        /// When shield regenerates - how many points it regenerates per tick. Tick is defined by game systems.
        /// </summary>
        [Preserve] public FP ShieldRegeneration { get; set; }

        /// <summary>
        /// How many energy points is required and consumed per regeneration tick.
        /// </summary>
        [Preserve] public FP EnergyCost { get; set; }
    }
}
