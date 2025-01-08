namespace SpaceSmuggler.Runtime
{
    /// <summary>
    /// This class contains final values used for moving entity.
    /// </summary>
    public sealed class EntityPhysics
    {
        public float Acceleration { get; set; }
        public float Mass { get; set; }
        public float Force { get; set; }
        public float RotationForce { get; set; }
        public float Drag { get; set; }
        public float RotationDrag { get; set; }
    }
}
