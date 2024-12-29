using System.Collections.Generic;

namespace SpaceSmuggler
{
    /// <summary>
    /// Ship holds all the information about a ship. It's like a template, static description so it
    /// does not provide runtime data like current amount of hull points, shield points etc.
    /// Ship is used to calculate all required values to be used during play session.
    /// </summary>
    public sealed class Ship
    {
        /// <summary>
        /// Every ship have unique name. It's NOT a player nickname.
        /// Example: Millennium Falcon, Scyth Scout etc.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ship provides HullPoints.
        /// It's a base value modified in calculations by <see cref="StatType.Strength"/> and <see cref="PropertyType.HullPoints"/>.
        /// Also affected by spells and buffs.
        /// </summary>
        public float HullPoints { get; set; }

        /// <summary>
        /// Mass is used to calculate acceleration and rotation speed.
        /// </summary>
        public float Mass { get; set; }

        /// <summary>
        /// Slots for pilots. This list count can be 0 on small ships.
        /// </summary>
        public List<PilotSeat> Pilots { get; set; }

        /// <summary>
        /// Available component slots on this ship.
        /// </summary>
        public List<ShipComponentSlot> Equipment { get; set; }

        /// <summary>
        /// Ship model is represented by its unique <see cref="Name"/> but this class overrides all the colors, textures, decals etc.
        /// </summary>
        public ShipAppearance Appearance { get; set; }
    }
}
