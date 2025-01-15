using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types
{
    /// <summary>
    /// Resource that is required by <see cref="Blueprint"/>s to be forged into <see cref="ShipComponent"/>.
    /// Scraps are dropped from destroyed opponents.
    /// Player can also melt them in the forge into <see cref="Ore"/>s.
    /// </summary>
    public sealed class Scrap
    {
        public OreType OreType { get; set; }
        public int Quantity { get; set; }
    }
}
