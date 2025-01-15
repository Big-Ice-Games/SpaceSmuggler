using BIG;
using Photon.Deterministic;

namespace SpaceSmuggler.Gameplay.Types
{
    [Preserve]
    public sealed class EngineBlueprint : Blueprint
    {
        /// <summary>
        /// How fast it goes to max force.
        /// </summary>
        [Preserve] public FP Acceleration { get; set; }

        /// <summary>
        /// Force limit.
        /// </summary>
        [Preserve] public FP MaxForce { get; set; }

        /// <summary>
        /// Rotation force. It's constant, not affected by acceleration.
        /// </summary>
        [Preserve] public FP RotationForce { get; set; }
    }
}
