using BIG;
using Photon.Deterministic;

namespace SpaceSmuggler.Gameplay.Types
{
    [Preserve]
    public sealed class EnergyCoreBlueprint : Blueprint
    {
        /// <summary>
        /// Max energy.
        /// </summary>
        [Preserve] public FP Energy { get; set; }

        /// <summary>
        /// How much energy we regenerate every tick. Tick is defined by game systems.
        /// </summary>
        [Preserve] public FP RegenerationRate { get; set; }
    }
}
