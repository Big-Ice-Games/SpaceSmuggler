using BIG;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types.Components
{
    /// <summary>
    /// Armor represents 4 components available to be used on every ship:
    /// <see cref="ShipComponentType.ArmorForward"/>
    /// <see cref="ShipComponentType.ArmorBackward"/>
    /// <see cref="ShipComponentType.ArmorStarboard"/>
    /// <see cref="ShipComponentType.ArmorLarboard"/>
    /// It provides armor points which are used for damage calculation against <see cref="Ship.HullPoints"/>.
    /// It has NO EFFECT against Shield Points damage calculation.
    /// <see cref="PropertyType.Armor"/> provides % value that increase the SUM fo all the armor points on the ship.
    /// </summary>
    [Preserve]
    public sealed class Armor : ShipComponent
    {
        [Preserve]
        public float ArmorPoints { get; set; }

        [Preserve]
        public Armor() {}
    }
}
