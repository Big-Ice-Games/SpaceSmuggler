namespace SpaceSmuggler
{
    /// <summary>
    /// Resource that is required by <see cref="BluePrint"/>s to be forged into <see cref="ShipComponent"/>.
    /// Scraps are dropped from destroyed opponents.
    /// Player can also melt them in the forge into <see cref="Ore"/>s.
    /// </summary>
    public sealed class Scrap
    {
        public OreType OreType { get; set; }
        public int Quantity { get; set; }
    }
}
