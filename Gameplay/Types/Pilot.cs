using System.Collections.Generic;

namespace SpaceSmuggler
{
    /// <summary>
    /// Special item type that represents pilot cards.
    /// These cards can be used to add additional properties to ship.
    /// </summary>
    public sealed class Pilot
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Portrait name assigned to this card.
        /// Used to get appropriate 2d asset in the game.
        /// </summary>
        public string Portrait { get; set; }

        /// <summary>
        /// Pilot rarity.
        /// </summary>
        public Rarity Rarity { get; set; }

        /// <summary>
        /// List of properties provided by this pilot.
        /// </summary>
        public List<Property> Properties { get; set; }
    }
}
