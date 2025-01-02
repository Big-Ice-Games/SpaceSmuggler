namespace SpaceSmuggler.Gameplay.Types
{
    /// <summary>
    /// Components have requirements. These requirements doesn't have to be meet in order to use it but if not all requirements are meet
    /// component is used only in certain % and no more than 80%.
    /// For example if component require 100 strength:
    /// If player have 50 strength he will use 50% of it.
    /// If player have 99 strength he will use 80% of it.
    /// If more than one requirement is not meet than the lowest % will be used.
    /// </summary>
    public sealed class Requirement
    {
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
    }
}
