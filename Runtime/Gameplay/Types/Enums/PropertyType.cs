namespace SpaceSmuggler.Gameplay.Types.Enums
{
    /// <summary>
    /// For details see <see cref="Property"/>.
    /// </summary>
    public enum PropertyType
    {
        /// <summary>
        /// Local - only weapon
        /// </summary>
        HitChance,

        /// <summary>
        /// Local - only weapon
        /// </summary>
        Damage,

        /// <summary>
        /// Local - only weapon
        /// </summary>
        ReloadTime,

        /// <summary>
        /// Local - weapon, shield, scanner
        /// </summary>
        EnergyEfficiency,

        /// <summary>
        /// Local - only weapon
        /// </summary>
        CriticalChance,

        /// <summary>
        /// Local - only scanner
        /// </summary>
        ScannerPoints,

        /// <summary>
        /// Local - only scanner
        /// </summary>
        ScannerFrequency,

        #region Global
        ShieldPoints,
        ShieldRegeneration,
        Resistance,
        Energy,
        EnergyRegeneration,
        SkillBonus,
        StatBonus,
        Acceleration,
        MaxForce,
        RotationSpeed,
        DodgeChance,
        Armor,
        HullPoints
        #endregion
    }
}
