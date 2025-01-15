using System.Collections.Generic;
using BIG;
using SpaceSmuggler.Gameplay.Runtime;
using SpaceSmuggler.Gameplay.Types;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Providers
{
    public sealed class PlayerProvider
    {
        public static Entity GetRandomEntity()
        {
            var pilot = GetRandomPilot();
            return new Entity();
        }

        public static Player GetRandomPlayer()
        {
            return new Player();
        }

        public static Ship GetRandomShip()
        {
            return new Ship();
        }


        /// <summary>
        /// Get random properties for component or pilot based on the rarity.
        /// </summary>
        /// <param name="rarity"></param>
        /// <returns></returns>
        public static List<Property> GetRandomProperties(Rarity rarity)
        {
            var amount = GetAmountOfPropertiesForRarity(rarity);
            List<Property> properties = new List<Property>(amount);
            for (int i = 0; i < amount; i++)
            {
                var type =  CollectionsExtension.GetRandomEnum<PropertyType>();
                StatType stat = type == PropertyType.StatBonus ? StatType.None.GetRandomEnum() : StatType.None;
                SkillType skill = type == PropertyType.SkillBonus ? SkillType.None.GetRandomEnum() : SkillType.None;
                properties.Add(new Property()
                {
                    Type = type,
                    SkillType = skill,
                    StatType = stat,
                    Value = GetPropertyValueForRarity(rarity)
                });
            }

            return properties;
        }

        /// <summary>
        /// Gets amount of property value for any property based on the rarity of component or pilot.
        /// </summary>
        /// <param name="rarity">Rarity of the pilot or component.</param>
        /// <returns>Value that should be used for <see cref="Property.Value"/>.</returns>
        public static int GetPropertyValueForRarity(Rarity rarity)
        {
            switch (rarity)
            {
                case Rarity.Common:
                case Rarity.Uncommon:
                    return CollectionsExtension.Random.MemoryFriendlyRandom(1, 4);
                case Rarity.Rare:
                case Rarity.Epic:
                    return CollectionsExtension.Random.MemoryFriendlyRandom(2, 5);
                case Rarity.Legendary:
                    return CollectionsExtension.Random.MemoryFriendlyRandom(3, 6);
                default:
                    return CollectionsExtension.Random.MemoryFriendlyRandom(4, 6);
            }
        }
        
        /// <summary>
        /// Based on rarity get amount of properties for component or pilot.
        /// </summary>
        /// <param name="rarity">Rarity of the pilot or component.</param>
        /// <returns>How many properties you should add on pilot or component.</returns>
        public static int GetAmountOfPropertiesForRarity(Rarity rarity)
        {
            switch (rarity)
            {
                case Rarity.Common:
                case Rarity.Uncommon: 
                    return 1;
                case Rarity.Rare:
                case Rarity.Epic:
                    return 2;
                case Rarity.Legendary:
                    return 3;
                default:
                    return 0;
            }
        }

        public static ShipComponent GetRandomComponent(ShipComponentType componentType)
        {
            switch (componentType)
            {
                case ShipComponentType.Beam:
                    return GetRandomBeamWeapon();
            }
        }

        public static Weapon GetRandomBeamWeapon()
        {
            return new Weapon();
        }

        public static Skills GetRandomSkills(int level)
        {
            return new Skills();
        }

        public static Stats GetRandomStats(int stats)
        {
            return new Stats();
        }
    }
}
