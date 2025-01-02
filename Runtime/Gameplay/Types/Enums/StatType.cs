namespace SpaceSmuggler.Gameplay.Types.Enums
{
    public enum StatType
    {
        None,

        /// <summary>
        /// Used in calculations with: tactics, resistance, rockets.
        /// Increase damage.
        /// </summary>
        Strength,

        /// <summary>
        /// Used in calculations with: tactics, repair, navigation, hide, dodge, disrupt, beam, backstab.
        /// Increase critical hit chance and dodge chance.
        /// </summary>
        Dexterity,

        /// <summary>
        /// Used in calculations with: shields, repair, ice kinesis, plasma, mining, hacking, focus, engineering.
        /// Increase psi points.
        /// </summary>
        Intelligence
    }
}
