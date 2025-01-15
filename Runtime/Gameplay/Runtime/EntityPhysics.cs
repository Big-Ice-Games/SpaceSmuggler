using Photon.Deterministic;

namespace SpaceSmuggler.Gameplay.Runtime
{
    /// <summary>
    /// This class contains final values used for moving entity.
    /// </summary>
    public sealed class EntityPhysics
    {
        public FP Acceleration { get; set; }
        public FP Mass { get; set; }
        public FP Force { get; set; }
        public FP RotationForce { get; set; }
        public FP Drag { get; set; }
        public FP RotationDrag { get; set; }
    }
}
