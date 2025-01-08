namespace SpaceSmuggler.Runtime
{
    public sealed class EntityShield
    {
        /// <summary>
        /// Is this component active or disabled by a player.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Maximum shield points.
        /// </summary>
        public float Shield { get; set; }

        /// <summary>
        /// Current shield points.
        /// </summary>
        public float CurrentShield { get; set; }

        /// <summary>
        /// How much shield points we can regenerate per tick.
        /// </summary>
        public float ShieldRegenerationTick { get; set; }

        /// <summary>
        /// How much energy points active shield is consuming every tick.
        /// </summary>
        public float ShieldRegenerationTickEnergyCost { get; set; }
    }
}
