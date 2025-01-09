namespace SpaceSmuggler.Gameplay.Runtime
{
    /// <summary>
    /// Used to display entity name in the game.
    /// </summary>
    public sealed class EntityDescription
    {
        public string Name { get; set; }
        public bool IsHero { get; set; }
        public bool IsHostile { get; set; }
        public bool IsBoss { get; set; }
    }
}
