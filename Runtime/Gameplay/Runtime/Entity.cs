using System.Collections.Generic;
using Photon.Deterministic;
using SpaceSmuggler.Gameplay.Types;

namespace SpaceSmuggler.Gameplay.Runtime
{
    /// <summary>
    /// This class represents players and other entities in the match.
    /// </summary>
    public class Entity
    {
        public Entity(
            EntityDescription description,
            ShipAppearance appearance,
            EntityShield shield,
            List<EntityWeapon> weapons,
            EntityEnergy energy,
            float hullPoints,
            float currentHullPoints,
            EntityPhysics physics)
        {
            Description = description;
            Appearance = appearance;
            Shield = shield;
            Weapons = weapons;
            Energy = energy;
            HullPoints = hullPoints;
            CurrentHullPoints = currentHullPoints;
            Physics = physics;
        }

        public Entity(){}

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
        /// Energy.
        /// </summary>
        public EntityEnergy Energy { get; set; }

        /// <summary>
        /// Maximum hull points
        /// </summary>
        public FP HullPoints { get; set; }

        /// <summary>
        /// Current hull points.
        /// </summary>
        public FP CurrentHullPoints { get; set; }

        /// <summary>
        /// Physics values for entity.
        /// </summary>
        public EntityPhysics Physics { get; set; }


    }
}
