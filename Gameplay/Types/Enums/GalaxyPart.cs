namespace SpaceSmuggler
{
    /// <summary>
    /// Game world is represented by galaxy which is divided into Galaxy Parts.
    /// These parts provides <see cref="BluePrint.ComponentSubtype"/> and in result <see cref="ShipComponent.ComponentSubType"/> on the crafted components.
    /// It is used mainly for tiers purpose.
    /// Player can be taught which parts are less and which are more advanced.
    /// Playing in certain galaxy parts will generate <see cref="BluePrint"/>s marked with this galaxy part as <see cref="BluePrint.ComponentSubtype"/>.
    /// </summary>
    public enum GalaxyPart
    {
        None,

        /// <summary>
        /// First location that players are starting in.
        /// This region is used for all the default components randomized for new players.
        /// </summary>
        Scyth
    }
}
