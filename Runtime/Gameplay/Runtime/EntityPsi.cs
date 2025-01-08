namespace SpaceSmuggler.Runtime
{
    /// <summary>
    /// Mana/psi model for entity.
    /// </summary>
    public sealed class EntityPsi
    {
        /// <summary>
        /// Maximum psi points.
        /// </summary>
        public float PsiPoints { get; set; }

        /// <summary>
        /// Current psi points.
        /// </summary>
        public float CurrentPsiPoints { get; set; }

        /// <summary>
        /// How much psi is regenerating every tick.
        /// </summary>
        public float PsiRegenerationTick { get; set; }
    }
}
