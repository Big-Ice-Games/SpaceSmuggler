using BIG;
using Photon.Deterministic;

namespace SpaceSmuggler.Gameplay.Types
{
    [Preserve]
    public sealed class ScannerBlueprint : Blueprint
    {
        /// <summary>
        /// How strong scanner is.
        /// </summary>
        [Preserve] public FP ScannerPoints { get; set; }

        /// <summary>
        /// How far from player it works.
        /// </summary>
        [Preserve] public FP Range { get; set; }

        /// <summary>
        /// How much energy it takes for every use.
        /// </summary>
        [Preserve] public FP EnergyCost { get; set; }

        /// <summary>
        /// How long it takes to load.
        /// </summary>
        [Preserve] public FP ReloadTime { get; set; }
    }
}
