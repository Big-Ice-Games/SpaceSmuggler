using System.Collections.Generic;
using BIG;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types
{
    /// <summary>
    /// Base class for every ship component.
    /// </summary>
    [Preserve]
    public sealed class ShipComponent
    {
        [Preserve] public string BlueprintName { get; set; }

        /// <summary>
        /// <see cref="ShipComponentType"/>
        /// </summary>
        [Preserve] public ShipComponentType ComponentType { get; set; }

        /// <summary>
        /// <see cref="Region"/>
        /// </summary>
        [Preserve] public Region ComponentSubType { get; set; }

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
