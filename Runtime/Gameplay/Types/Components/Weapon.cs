using BIG;

namespace SpaceSmuggler.Gameplay.Types.Components
{
    /// <summary>
    /// Ship can hold multiple weapons.
    /// Every weapon have a <see cref="ShipComponent.ComponentType"/> that represents type.
    /// </summary>
    [Preserve]
    public sealed class Weapon : ShipComponent
    {
        /// <summary>
        /// Every shot calculates damage between min and max damage.
        /// </summary>
        [Preserve] public float MinDamage { get; set; }

        /// <summary>
        /// Every shot calculates damage between min and max damage.
        /// </summary>
        [Preserve] public float MaxDamage { get; set; }

        /// <summary>
        /// Weapon cooldown.
        /// </summary>
        [Preserve] public float ReloadTime { get; set; }

        /// <summary>
        /// Amount of energy consumed during a single reload time
        /// Reload is updated in ticks. Every tick take a % of energy based on reload time.
        /// <example>
        /// If <see cref="ReloadTime"/> is equal 1 and <see cref="EnergyConsumption"/> is equal 100 and reloading ticks taking place 10 times per second it mean that every tick
        /// will reload 10% of cooldown and consume 10 energy. So loading weapon will takes 1 second and consume 100 energy.
        /// </example>
        /// </summary>
        [Preserve] public float EnergyConsumption { get; set; }

        /// <summary>
        /// Obvious.
        /// </summary>
        [Preserve] public float Range { get; set; }
    }
}
