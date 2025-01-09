using System.Collections.Generic;
using SpaceSmuggler.Gameplay.Types;

namespace SpaceSmuggler.Gameplay.Runtime
{
    /// <summary>
    /// This class represents players and other entities in the match.
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// Description is used to display entity name and UI type on the game client side.
        /// </summary>
        public EntityDescription Description { get; set; }

        /// <summary>
        /// How this entity looks like.
        /// </summary>
        public ShipAppearance Appearance { get; set; }

        /// <summary>
        /// Shield.
        /// </summary>
        public EntityShield Shield { get; set; }

        /// <summary>
        /// List of weapons.
        /// </summary>
        public List<EntityWeapon> Weapons { get; set; }

        /// <summary>
        /// Psi (mana).
        /// </summary>
        public EntityPsi Psi { get; set; }

        /// <summary>
        /// Energy.
        /// </summary>
        public EntityEnergy Energy { get; set; }

        /// <summary>
        /// Maximum hull points
        /// </summary>
        public float HullPoints { get; set; }

        /// <summary>
        /// Current hull points.
        /// </summary>
        public float CurrentHullPoints { get; set; }

        /// <summary>
        /// Physics values for entity.
        /// </summary>
        public EntityPhysics Physics { get; set; }
    }
}
