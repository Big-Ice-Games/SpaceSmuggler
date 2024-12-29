namespace SpaceSmuggler
{
    /// <summary>
    /// <see cref="ShipComponent"/> and <see cref="Pilot"/> can provides properties.
    /// Properties are accumulated on game entity to increase it's final values.
    /// Some of the properties <see cref="PropertyType"/> described as local works only for them selves.
    /// What it mean is that for example <see cref="Weapon"/> that increase its <see cref="PropertyType.HitChance"/>
    /// increase it only for this weapon - not for all the other weapons on the ship.
    ///
    /// If <see cref="PropertyType"/> is <see cref="PropertyType.SkillBonus"/> or <see cref="PropertyType.StatBonus"/>
    /// it will store specified <see cref="SkillType"/> or <see cref="StatType"/> in associated fields. Otherwise these field should store enum values "None".
    ///
    /// Value of the property is always stored in <see cref="Value"/> field.
    /// In most of cases it represents % Percentage % value.
    /// </summary>
    public sealed class Property
    {
        /// <summary>
        /// Type of bonus it provides.
        /// </summary>
        public PropertyType Type { get; set; }

        /// <summary>
        /// Used only for PropertyType.SkillPointsBonus
        /// </summary>
        public SkillType SkillType { get; set; }

        /// <summary>
        /// Used only for PropertyType.StatBonus
        /// </summary>
        public StatType StatType { get; set; }

        /// <summary>
        /// Value of the bonus. In most cases %.
        /// </summary>
        public float Value { get; set; }
    }
}
