using BIG;

namespace SpaceSmuggler.Gameplay.Types
{
    /// <summary>
    /// Ship holds all the information about a ship. It's like a template, static description so it
    /// does not provide runtime data like current amount of hull points, shield points etc.
    /// Ship is used to calculate all required values to be used during play session.
    /// </summary>
    [Preserve]
    public sealed class Ship
    {
        /// <summary>
        /// Player may have multiple ships. This id is used to aim specific ship from players collection.
        /// </summary>
        [Preserve] public string ShipId { get; set; }

        /// <summary>
        /// Ship appearance can override default one from <see cref="ShipBlueprint"/>
        /// </summary>
        [Preserve] public ShipAppearance Appearance { get; set; }

        [Preserve] public ShipBlueprint ShipBlueprint { get; set; }

        [Preserve] public Equipment Equipment { get; set; }

        [Preserve] public Ship(){}

        [Preserve]
        public Ship(string shipId, ShipBlueprint blueprint)
        {
            ShipId = shipId;
            Appearance = blueprint.ShipAppearance;
            ShipBlueprint = blueprint;
            Equipment = new Equipment(blueprint.WeaponSlots, blueprint.ArmorSlots, blueprint.PilotSeats);
        }
    }
}
