using System.Collections.Generic;
using SpaceSmuggler.Gameplay.Types.Components;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types
{
    /// <summary>
    /// BluePrint is an object that can be used to create a new <see cref="ShipComponent"/>.
    /// BluePrint have its own cost in a form of scraps and ores.
    /// In addition, during forging process Credits cost is added.
    /// </summary>
    public sealed class BluePrint
    {
        /// <summary>
        /// What type of component is this blueprint for.
        /// </summary>
        public ShipComponentType ComponentType { get; set; }

        /// <summary>
        /// BluePrint origin.
        /// </summary>
        public GalaxyPart ComponentSubtype { get; set; }

        /// <summary>
        /// Which scraps and how many of them we need to create this component.
        /// </summary>
        public List<Scrap> ScrapCost { get; set; }

        /// <summary>
        /// Which ores and how many of them we need to create this component.
        /// </summary>
        public List<Ore> OreCost { get; set; }
    }
}
