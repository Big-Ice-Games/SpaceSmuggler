using SpaceSmuggler.Gameplay.Types.Components;

namespace SpaceSmuggler.Gameplay.Types.Enums
{
    /// <summary>
    /// Resource that is required by <see cref="BluePrint"/>s to be forged into <see cref="ShipComponent"/>.
    /// Ores have different amount of rarity.
    /// Player can get it in a form of <see cref="Ore"/> from expeditions and mining it on missions.
    /// It can be also melted from <see cref="Scrap"/>s. which are also represented by <see cref="OreType"/>.
    /// </summary>
    public enum OreType
    {
        Carbon,
        Verite,
        Valorite,
        Bon,
        Shadow,
        Lux
    }
}
