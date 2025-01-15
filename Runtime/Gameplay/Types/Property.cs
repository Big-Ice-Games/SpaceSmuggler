using System;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types
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
    /// In most of the cases it represents % Percentage % value.
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
        public int Value { get; set; }

        public static bool operator ==(Property p1, Property p2)
        {
            if ((object)p1 == null)
                return (object)p2 == null;

            return p1.Equals(p2);
        }

        public static bool operator !=(Property p1, Property p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var p2 = (Property)obj;
            return (Type == p2.Type && SkillType == p2.SkillType && StatType == p2.StatType);
        }

        public override int GetHashCode()
        {
            return Type.GetHashCode() ^ SkillType.GetHashCode() ^ StatType.GetHashCode();
        }
    }
}
