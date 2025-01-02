using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types
{
    /// <summary>
    /// Hold all the stats values for an entity.
    /// Stats like skills are a part of a player account and its progression.
    /// For AI entities stats are generated based on the entity level etc.
    /// </summary>
    public sealed class Stats
    {
        /// <summary>
        /// <see cref="StatType.Strength"/>
        /// </summary>
        public int Strength { get; set; }

        /// <summary>
        /// <see cref="StatType.Dexterity"/>
        /// </summary>
        public int Dexterity { get; set; }

        /// <summary>
        /// <see cref="StatType.Intelligence"/>
        /// </summary>
        public int Intelligence { get; set; }
    }
}
