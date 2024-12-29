using BIG;

namespace SpaceSmuggler
{
    /// <summary>
    /// Scanner provides two important features:
    /// 1. Information exchange between ships. Depending on difference between ship points it will reveal ship on the local map and provide some level of information.
    /// Detailed algorithm is not implemented yet.
    /// 2. Every tick can reveal hidden ships around based on their hiding skill against scanner points and distance between ships.
    /// </summary>
    [Preserve]
    public sealed class Scanner : ShipComponent
    {
        /// <summary>
        /// How strong scanner is.
        /// </summary>
        [Preserve] public float ScannerPoints { get; set; }

        /// <summary>
        /// How far from player it works.
        /// </summary>
        [Preserve] public float Range { get; set; }

        /// <summary>
        /// How much energy it takes for every tick.
        /// </summary>
        [Preserve] public float EnergyConsumption { get; set; }

        /// <summary>
        /// How often it ticks.
        /// </summary>
        [Preserve] public float ScannerFrequency { get; set; }

        [Preserve] public Scanner(){}
    }
}
