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
    }
}
