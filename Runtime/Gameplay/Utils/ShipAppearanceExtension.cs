using BIG;
using BIG.Types;
using SpaceSmuggler.Gameplay.Types;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Utils
{
    public static class ShipAppearanceExtension
    {
        public static ShipAppearance Randomize(this ShipAppearance shipAppearance)
        {
            shipAppearance.Name = "Test";
            shipAppearance.ColorA = Color.Default.Randomize();
            shipAppearance.ColorB = Color.Default.Randomize();
            shipAppearance.ColorC = Color.Default.Randomize();
            shipAppearance.Emission = Color.Default.Randomize();
            shipAppearance.ThrustersColor = Color.Default.Randomize();

            shipAppearance.DecalA = ShipDecal.None;
            shipAppearance.DecalB = ShipDecal.None;
            shipAppearance.SpecialTexture = SpecialTexture.None;
            return shipAppearance;
        }
    }
}
