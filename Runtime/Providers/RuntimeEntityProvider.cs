using System.Collections.Generic;
using System.Linq;
using SpaceSmuggler.Gameplay.Runtime;
using SpaceSmuggler.Gameplay.Types;
using SpaceSmuggler.Gameplay.Types.Enums;
using SpaceSmuggler.Gameplay.Utils;

namespace SpaceSmuggler.Providers
{
    /// <summary>
    /// This class convert Gameplay.Types into Gameplay.Runtime entities.
    /// </summary>
    public static class RuntimeEntityProvider
    {
        public static Entity ToRuntimeEntity(this Ship ship, Skills skills, Stats stats)
        {
            var properties = ship.Equipment.GetAllProperties();

            // Apply properties to skills and stats so we don't need to search through them later. We are summing them up.
            skills.Apply(properties);
            stats.Apply(properties);

            EntityShield shield = GetEntityShield(
                ship.Equipment.Shield.Component,
                properties,
                skills,
                stats);

            EntityEnergy energy = GetEntityEnergy(
                ship.Equipment.EnergyCore.Component,
                properties,
                skills,
                stats);

            return new Entity(
                new EntityDescription(),
                ship.Appearance,
                shield,
                new List<EntityWeapon>(),
                new EntityEnergy(),
                1,
                1,
                new EntityPhysics(),
                0,
                0,
                0);
        }

        public static EntityShield GetEntityShield(ShipComponent? shieldComponent, List<Property> properties, Skills skills, Stats stats)
        {
            if(shieldComponent == null)
                return new EntityShield();

            var shieldPointsBonus = properties.FirstOrDefault(s => s.Type == PropertyType.ShieldPoints)?.Value ?? 0;
            var shieldPointsRegenerationBonus = properties.FirstOrDefault(s => s.Type == PropertyType.ShieldRegeneration)?.Value ?? 0;

            ShieldBlueprint shieldBlueprint = (ShieldBlueprint)shieldComponent.GetBlueprint();
            var statsSkillMultiplier = (1 + stats.Intelligence / 125);
            var skillAfterStatsMultiplier = skills.Shields * statsSkillMultiplier;
            var baseShieldSkillMultiplier = 1 + skillAfterStatsMultiplier / 120;
            var shieldPoints = shieldBlueprint.ShieldPoints * baseShieldSkillMultiplier + shieldPointsBonus;

            var baseRegeneration = shieldBlueprint.ShieldRegeneration;
            var improvedRegeneration = baseRegeneration * ((100 + shieldPointsRegenerationBonus) / 100);

            return new EntityShield(shieldPoints, improvedRegeneration, shieldBlueprint.EnergyCost);
        }

        public static EntityEnergy GetEntityEnergy(ShipComponent? shipComponent, List<Property> properties, Skills skills, Stats stats)
        {
            if (shipComponent == null)
                return new EntityEnergy();

            var energyBonus = properties.FirstOrDefault(s => s.Type == PropertyType.Energy)?.Value ?? 0;
            var energyRegenerationBonus = properties.FirstOrDefault(s => s.Type == PropertyType.EnergyRegeneration)?.Value ?? 0;

            //EnergyCoreBlueprint bl
        }
    }
}
