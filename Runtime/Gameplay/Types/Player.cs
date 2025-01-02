using System.Collections.Generic;

namespace SpaceSmuggler.Gameplay.Types
{
    /// <summary>
    /// Represents player and everything he have.
    /// </summary>
    public sealed class Player
    {
        /// <summary>
        /// Player level.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Player experience.
        /// </summary>
        public int Experience { get; set; }

        /// <summary>
        /// Player skills.
        /// </summary>
        public Skills Skills { get; set; }

        /// <summary>
        /// Player Stats.
        /// </summary>
        public Stats Stats { get; set; }

        /// <summary>
        /// Player ships.
        /// </summary>
        public List<Ship> Ships { get; set; }

        /// <summary>
        /// Player pilot cards.
        /// </summary>
        public List<Pilot> Pilots { get; set; }
    }
}
