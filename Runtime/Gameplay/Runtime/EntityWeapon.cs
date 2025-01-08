namespace SpaceSmuggler.Runtime
{
    public sealed class EntityWeapon
    {
        /// <summary>
        /// Is this component active or disabled by a player.
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// How this weapon shot is represented on the client side.
        /// </summary>
        public ShootType ShootType { get; set; }

        /// <summary>
        /// Min damage for calculation.
        /// </summary>
        public float MinDamage { get; set; }

        /// <summary>
        /// Max damage for calculation.
        /// </summary>
        public float MaxDamage { get; set; }

        /// <summary>
        /// Chance for success hit.
        /// </summary>
        public float HitChance { get; set; }

        /// <summary>
        /// Chance for critical hit. Used for calculation only for success hit.
        /// </summary>
        public float CriticalHitChance { get; set; }

        /// <summary>
        /// How much damage is increased for critical hit.
        /// </summary>
        public float CriticalHitMultiplier { get; set; }
      
        /// <summary>
        /// How much energy this weapon consume for full reload.
        /// </summary>
        public float EnergyCost { get; set; }

        /// <summary>
        /// How much energy is currently loaded into weapon.
        /// </summary>
        public float CurrentEnergy { get; set; }

        /// <summary>
        /// How much energy active weapon consume per tick if CurrentEnergy is lower than EnergyCost.
        /// </summary>
        public float EnergyLoadPerTick { get; set; }

        /// <summary>
        /// Is this weapon require energy in the next tick?
        /// </summary>
        /// <returns>Energy cost for the next tick.</returns>
        public float GetEnergyCost()
        {
            if (!IsActive) return 0;
            if (CurrentEnergy < EnergyCost)
                return EnergyLoadPerTick;

            return 0;
        }

        /// <summary>
        /// When const is calculated for all components we measure how much we need in this tick.
        /// If we have enough energy this tick is performed with value 1.
        /// If we don't have enough energy, to avoid loading all the energy into first component we are splitting it into all components that require energy.
        /// </summary>
        /// <param name="tickPercentageValue">Value 1 or less.
        /// This value is multiplied by <see cref="EnergyLoadPerTick"/> to define how much energy we load on this weapon in this tick.</param>
        /// So there is no guarantee that every tick will recover full <see cref="EnergyLoadPerTick"/> value.
        public void Tick(float tickPercentageValue)
        {
            if(!IsActive) return;
            var loadAmount = EnergyLoadPerTick * tickPercentageValue;
            CurrentEnergy += loadAmount;
        }
    }
}
