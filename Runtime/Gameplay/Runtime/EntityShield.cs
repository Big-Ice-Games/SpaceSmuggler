namespace SpaceSmuggler.Runtime
{
    /// <summary>
    /// Shield model for runtime entity.
    /// </summary>
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

        /// <summary>
        /// Is this shield require energy in the next tick?
        /// </summary>
        /// <returns>Energy cost for the next tick.</returns>
        public float GetEnergyCost() => IsActive ? ShieldRegenerationTickEnergyCost : 0;

        /// <summary>
        /// When const is calculated for all components we measure how much we need in this tick.
        /// If we have enough energy this tick is performed with value 1.
        /// If we don't have enough energy, to avoid loading all the energy into first component we are splitting it into all components that require energy.
        /// </summary>
        /// <param name="tickPercentageValue">Value 1 or less.
        /// This value is multiplied by <see cref="ShieldRegenerationTickEnergyCost"/> and result is multiplied by <see cref="ShieldRegenerationTick"/> to load shield.
        /// So there is no guarantee that every tick will recover full <see cref="ShieldRegenerationTick"/> value.</param>.
        public void Tick(float tickPercentageValue)
        {
            if(!IsActive) return;
            var loadWeight = ShieldRegenerationTickEnergyCost * tickPercentageValue;
            var loadAmount = ShieldRegenerationTick * loadWeight;
            CurrentShield += loadAmount;
            if(CurrentShield > Shield)
                CurrentShield = Shield;
        }
    }
}
