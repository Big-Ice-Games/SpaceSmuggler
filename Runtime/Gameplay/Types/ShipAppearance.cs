using BIG;
using BIG.Types;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types
{
    /// <summary>
    /// Ship is basically represented in the game by game model.
    /// This class add colors to 3 available color slots and single emission color
    /// for all shiny parts.
    /// <see cref="SpecialTexture"/> can override colors applying special appearance to the ship.
    /// <see cref="DecalA"/> and <see cref="DecalB"/> may assign special decals on up to 2 available decal slots.
    /// </summary>
    [Preserve]
    public sealed class ShipAppearance
    {
        [Preserve] public Color ColorA { get; set; }
        [Preserve] public Color ColorB { get; set; }
        [Preserve] public Color ColorC { get; set; }
        [Preserve] public Color Emission { get; set; }
        [Preserve] public Color ThrustersColor { get; set; }
        [Preserve] public SpecialTexture SpecialTexture { get; set; }
        [Preserve] public ShipDecal DecalA { get; set; }
        [Preserve] public ShipDecal DecalB { get; set; }
    }
}
