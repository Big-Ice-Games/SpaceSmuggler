using System.Collections.Generic;
using System.Linq;
using SpaceSmuggler.Gameplay.Runtime;
using SpaceSmuggler.Gameplay.Types;

namespace SpaceSmuggler.Providers
{
    /// <summary>
    /// This class convert Gameplay.Types into Gameplay.Runtime entities.
    /// </summary>
    public static class RuntimeEntityProvider
    {
        public static Entity ToRuntimeEntity(this Player player, Blueprints blueprints, string shipId)
        {
            var ship = player.Ships.FirstOrDefault(s => s.ShipId == shipId);
            var properties = ship.Equipment.GetAllProperties();

            return new Entity(
                new EntityDescription(),
                ship.Appearance,
                GetEntityShield(
                    ship.Equipment.Shield.Component,
                    blueprints.GetBlueprint(ship.Equipment.Shield.Component),
                    properties,
                    player.Skills,
                    player.Stats),
                new List<EntityWeapon>(),
                new EntityEnergy(),
                1,
                1,
                new EntityPhysics());
        }

        public static EntityShield GetEntityShield(ShipComponent shieldComponent, IBlueprint blueprint, List<Property> properties, Skills skills, Stats stats)
        {
            return new EntityShield();
        }
    }
}
