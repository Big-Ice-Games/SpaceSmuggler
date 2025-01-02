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
    public sealed class ShipAppearance
    {
        public Color ColorA { get; set; }
        public Color ColorB { get; set; }
        public Color ColorC { get; set; }
        public Color Emission { get; set; }
        public Color ThrustersColor { get; set; }
        public SpecialTexture SpecialTexture { get; set; }
        public ShipDecal DecalA { get; set; }
        public ShipDecal DecalB { get; set; }
    }
}
