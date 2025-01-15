using BIG;

namespace SpaceSmuggler.Gameplay.Types
{
    [Preserve]
    public sealed class PilotBlueprint : Blueprint
    {
        /// <summary>
        /// Name.
        /// </summary>
        [Preserve] public string Name { get; set; }

        /// <summary>
        /// Portrait name assigned to this card.
        /// Used to get appropriate 2d asset in the game.
        /// </summary>
        [Preserve] public string Portrait { get; set; }
    }
}
