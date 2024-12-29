using BIG;

namespace SpaceSmuggler
{
    /// <summary>
    /// Engine component provides physics values for ship movement.
    /// It define how fast ship can fly, how fast it accelerate and how fast it can rotate.
    /// These values have to be perceived in comparison to <see cref="Ship.Mass"/>.
    /// </summary>
    [Preserve]
    public sealed class Engine : ShipComponent
    {
        /// <summary>
        /// How fast it goes to max force.
        /// </summary>
        [Preserve] public float Acceleration { get; set; }

        /// <summary>
        /// Force limit.
        /// </summary>
        [Preserve] public float MaxForce { get; set; }

        /// <summary>
        /// Rotation force. It's constant, not affected by acceleration.
        /// </summary>
        [Preserve] public float RotationForce { get; set; }

        [Preserve] public Engine(){}
    }
}
