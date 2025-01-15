using BIG;

namespace SpaceSmuggler.Gameplay.Types
{
    [Preserve]
    public sealed class ShipBlueprint
    {
        [Preserve] public string ShipName { get; set; }
        [Preserve] public ShipAppearance ShipAppearance { get; set; }
        [Preserve] public int Hp { get; set; }
        [Preserve] public int Mass { get; set; }
        [Preserve] public int WeaponSlots { get; set; }
        [Preserve] public int ArmorSlots { get; set; }
        [Preserve] public int PilotSeats { get; set; }
    }
}
