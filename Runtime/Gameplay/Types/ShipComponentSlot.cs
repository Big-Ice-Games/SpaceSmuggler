using BIG;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types
{
    /// <summary>
    /// This class describe equipment slots on the ship.
    /// Every slot have a specified <see cref="ShipComponentType"/> that it can hold and
    /// component that can be attached but also can be empty (null). 
    /// </summary>
    [Preserve]
    public sealed class ShipComponentSlot
    {
        [Preserve] public ShipComponentType SlotType { get; set; }
        [Preserve] public ShipComponent? Component { get; set; }
        [Preserve] public ShipComponentSlot(){}

        [Preserve]
        public ShipComponentSlot(ShipComponentType slotType)
        {
            SlotType = slotType;
        }

        [Preserve]
        public ShipComponentSlot(ShipComponentType slotType, ShipComponent shipComponent)
        {
            SlotType = slotType;
            Component = shipComponent;
        }
    }
}
