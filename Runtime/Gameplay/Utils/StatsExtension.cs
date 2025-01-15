using SpaceSmuggler.Gameplay.Types.Enums;
using SpaceSmuggler.Gameplay.Types;
using System.Collections.Generic;

namespace SpaceSmuggler.Gameplay.Utils
{
    public static class StatsExtension
    {
        public static void Apply(this Stats stats, List<Property> properties)
        {
            foreach (Property property in properties)
            {
                if (property.Type == PropertyType.StatBonus)
                    stats.Increase(property.StatType, property.Value);
            }
        }

        public static void Increase(this Stats stats, StatType statType, int value)
        {
            switch (statType)
            {
                case StatType.Strength: stats.Strength += value; break;
                case StatType.Dexterity: stats.Dexterity += value; break;
                case StatType.Intelligence: stats.Intelligence += value; break;
            }
        }
    }
}
