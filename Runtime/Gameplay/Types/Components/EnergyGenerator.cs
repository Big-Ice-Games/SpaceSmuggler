using BIG;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types.Components
{
    /// <summary>
    /// The most important component on every ship.
    /// It generates <see cref="Energy"/> amount and <see cref="RegenerationRate"/> speed of its regeneration.
    /// <see cref="Weapon"/>s, <see cref="ShieldGenerator"/>s and <see cref="Scanner"/>s require and consume energy.
    /// Better components require more energy.
    /// Energy is consumed during <see cref="Weapon"/> reloading, <see cref="ShieldGenerator"/> regeneration and for each <see cref="Scanner"/> tick.
    /// <see cref="PropertyType.EnergyEfficiency"/> property on component can decrease amount of energy consumed by this particular energy.
    ///
    /// Energy is also a cost of many abilities. For more details check <see cref="Skills"/> and look for "Cost energy" phrase. 
    /// </summary>
    [Preserve]
    public sealed class EnergyGenerator : ShipComponent
    {
        /// <summary>
        /// Max energy.
        /// </summary>
        [Preserve] public float Energy { get; set; }

        /// <summary>
        /// How much energy we regenerate every tick. Tick is defined by game systems.
        /// </summary>
        [Preserve] public float RegenerationRate { get; set; }

        [Preserve] public EnergyGenerator(){}
    }
}
