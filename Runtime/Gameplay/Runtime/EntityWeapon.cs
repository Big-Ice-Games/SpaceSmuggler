using Photon.Deterministic;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Runtime
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
        public FP MinDamage { get; set; }

        /// <summary>
        /// Max damage for calculation.
        /// </summary>
        public FP MaxDamage { get; set; }

        /// <summary>
        /// Chance for success hit.
        /// </summary>
        public FP HitChance { get; set; }

        /// <summary>
        /// Chance for critical hit. Used for calculation only for success hit.
        /// </summary>
        public FP CriticalHitChance { get; set; }

        /// <summary>
        /// How much damage is increased for critical hit.
        /// </summary>
        public FP CriticalHitMultiplier { get; set; }
      
        /// <summary>
        /// How much energy this weapon consume by shoot.
        /// </summary>
        public FP EnergyCost { get; set; }

        /// <summary>
        /// Weapon cooldown.
        /// </summary>
        public FP Cooldown { get; set; }
    }
}
