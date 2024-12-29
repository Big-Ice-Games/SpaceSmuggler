using BIG;

namespace SpaceSmuggler
{
    /// <summary>
    /// Generates <see cref="ShieldPoints"/> amount of points.
    /// While ship is not attacked for a while it enters peace mode which starts generating shield points.
    /// It generates <see cref="ShieldRegeneration"/> amount of points and consume <see cref="EnergyConsumption"/> amount of energy per tick.
    /// </summary>
    [Preserve]
    public sealed class ShieldGenerator : ShipComponent
    {
        /// <summary>
        /// Max shield points.
        /// </summary>
        [Preserve] public float ShieldPoints { get; set; }

        /// <summary>
        /// When shield regenerates - how many points it regenerates per tick. Tick is defined by game systems.
        /// </summary>
        [Preserve] public float ShieldRegeneration { get; set; }

        /// <summary>
        /// How many energy points is required and consumed per regeneration tick.
        /// </summary>
        [Preserve] public float EnergyConsumption { get; set; }

        [Preserve] public ShieldGenerator(){}
    }
}
