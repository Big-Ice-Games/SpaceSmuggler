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

            shipAppearance.DecalA = GetRandomDecal();
            shipAppearance.DecalB = GetRandomDecal();
            shipAppearance.SpecialTexture = GetSpecialRandomTexture();
            return shipAppearance;
        }

        /// <summary>
        /// Gives 10% chance for special texture.
        /// </summary>
        /// <returns>Special texture to be assigned in <see cref="ShipAppearance.SpecialTexture"/></returns>
        public static SpecialTexture GetSpecialRandomTexture()
        {
            var chance = CollectionsExtension.Random.MemoryFriendlyRandom(0, 1000);
            return chance > 900 ? SpecialTexture.None.GetRandomEnum() : SpecialTexture.None;
        }

        /// <summary>
        /// Gives 10% chance for decal.
        /// </summary>
        /// <returns>Decal to be assigned in <see cref="ShipAppearance"/></returns>
        public static ShipDecal GetRandomDecal()
        {
            var chance = CollectionsExtension.Random.MemoryFriendlyRandom(0, 1000);
            return chance > 900 ? ShipDecal.None.GetRandomEnum() : ShipDecal.None;
        }
    }
}
