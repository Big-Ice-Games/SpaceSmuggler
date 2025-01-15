// ReSharper disable All
namespace SpaceSmuggler.Gameplay.Types.Enums
{
    /// <summary>
    /// Game world is represented by planet and galaxy which is divided into Regions.
    /// These regions provide <see cref="Blueprint.ComponentSubtype"/> and in result <see cref="ShipComponent.ComponentSubType"/> on the crafted components.
    /// It is used mainly for tiers purpose.
    /// Player can be taught which parts are less and which are more advanced.
    /// Playing in certain regions will generate <see cref="Blueprint"/>s marked with this region as <see cref="Blueprint.ComponentSubtype"/>.
    /// </summary>
    public enum Region
    {
        None,

        /// <summary>
        /// First location that players are starting in.
        /// This region is used for all the default components randomized for new players.
        /// </summary>
        Mostki,

        Wars,

        Gliv,

        Berlin,

        Paris,

        Prague,

        Minsk,

        Moscow,


    }
}
