using Photon.Deterministic;

namespace SpaceSmuggler.Gameplay.Runtime
{
    /// <summary>
    /// Shield model for runtime entity.
    /// </summary>
    public sealed class EntityShield
    {
        public EntityShield(FP shield, FP shieldRegenerationPerSystemTick, FP shieldRegenerationEnergyCostPerSystemTick)
        {
            IsActive = true;
            Shield = shield;
            CurrentShield = shield;
            ShieldRegenerationPerSystemTick = shieldRegenerationPerSystemTick;
            ShieldRegenerationEnergyCostPerSystemTick = shieldRegenerationEnergyCostPerSystemTick;
        }

        public EntityShield() {}

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
