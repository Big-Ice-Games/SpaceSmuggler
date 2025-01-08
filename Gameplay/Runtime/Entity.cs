using System.Collections.Generic;

namespace SpaceSmuggler.Runtime
{
    /// <summary>
    /// This class represents players and other entities in the match.
    /// Work in progress..
    /// </summary>
    public class Entity
    {
        public EntityShield Shield { get; set; }

        public List<EntityWeapon> Weapons { get; set; }

        public EntityPsi Psi { get; set; }

        /// <summary>
        /// Maximum hull points
        /// </summary>
        public float HullPoints { get; set; }

        /// <summary>
        /// Current hull points.
        /// </summary>
        public float CurrentHullPoints { get; set; }

        

        
    }
}
