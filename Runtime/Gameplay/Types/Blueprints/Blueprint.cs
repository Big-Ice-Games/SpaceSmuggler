using System.Collections.Generic;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types
{
    public interface IBlueprint
    {
        string Name { get; set; }
        ShipComponentType ComponentType { get; set; }
        Region ComponentSubtype { get; set; }
        List<Scrap> ScrapCost { get; set; }
        List<Ore> OreCost { get; set; }
    }

    /// <summary>
    /// Blueprint is an object that can be used to create a new <see cref="ShipComponent"/>.
    /// Blueprint have its own cost in a form of scraps and ores.
    /// In addition, during forging process Credits cost is added.
    /// </summary>
    public abstract class Blueprint : IBlueprint
    {
        public string Name { get; set; }
        /// <summary>
        /// What type of component is this blueprint for.
        /// </summary>
        public ShipComponentType ComponentType { get; set; }

        /// <summary>
        /// Blueprint origin.
        /// </summary>
        public Region ComponentSubtype { get; set; }

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
