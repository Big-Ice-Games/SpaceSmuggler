using BIG;

namespace SpaceSmuggler
{
    /// <summary>
    /// This class describe equipment slots on the ship.
    /// Every slot have a specified <see cref="ShipComponentType"/> that it can hold and
    /// component that can be attached but also can be empty (null). 
    /// </summary>
    [Preserve]
    public sealed class ShipComponentSlot
    {
        [Preserve] public ShipComponentType ShipComponentType { get; set; }
        [Preserve] public ShipComponent Component { get; set; } 
    }
}
