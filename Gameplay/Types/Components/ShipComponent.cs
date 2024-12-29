using System.Collections.Generic;
using BIG;

namespace SpaceSmuggler
{
    /// <summary>
    /// Base class for every ship component.
    /// </summary>
    [Preserve]
    public abstract class ShipComponent
    {
        /// <summary>
        /// <see cref="ShipComponentType"/>
        /// </summary>
        [Preserve] public ShipComponentType ComponentType { get; set; }

        /// <summary>
        /// <see cref="GalaxyPart"/>
        /// </summary>
        [Preserve] public GalaxyPart ComponentSubType { get; set; }

        /// <summary>
        /// <see cref="Rarity"/>
        /// </summary>
        [Preserve] public Rarity Rarity { get; set; }

        /// <summary>
        /// <see cref="Requirement"/>
        /// </summary>
        [Preserve] public Requirement Requirement { get; set; }

        /// <summary>
        /// <see cref="Property"/>
        /// </summary>
        [Preserve] public List<Property> Properties { get; set; }
    }
}
