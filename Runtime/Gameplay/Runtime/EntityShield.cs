using System.Collections.Generic;
using Photon.Deterministic;
using SpaceSmuggler.Gameplay.Types;

namespace SpaceSmuggler.Gameplay.Runtime
{
    /// <summary>
    /// Shield model for runtime entity.
    /// </summary>
    public sealed class EntityShield
    {
        public EntityShield(ShipComponent shieldComponent, ShieldBlueprint blueprint, List<Property> properties, Skills skills, Stats stats)
        {

        }

        public EntityShield(){}

        /// <summary>
        /// Is this component active or disabled by a player.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Maximum shield points.
        /// </summary>
        public FP Shield { get; set; }

        /// <summary>
        /// Current shield points.
        /// </summary>
        public FP CurrentShield { get; set; }

        /// <summary>
        /// How much shield points we can regenerate per tick.
        /// </summary>
        public FP ShieldRegenerationPerSystemTick { get; set; }

        /// <summary>
        /// How much energy points active shield is consuming every tick while it is not fully loaded.
        /// </summary>
        public FP ShieldRegenerationEnergyCostPerSystemTick { get; set; }
    }
}
