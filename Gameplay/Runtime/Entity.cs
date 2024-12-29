namespace SpaceSmuggler.Runtime
{
    /// <summary>
    /// This class represents players and other entities in the match.
    /// Work in progress..
    /// </summary>
    public class Entity
    {
        public float Shield { get; set; }
        public float ShieldRegenerationTick { get; set; }
        public float HullPoints { get; set; }
        public float PsiPoints { get; set; }
        public float PsiRegenerationTick { get; set; }
        public int LastTickReceivedDamage { get; set; }
    }
}
