using Photon.Deterministic;

namespace SpaceSmuggler.Gameplay.Runtime
{
    public sealed class EntityEnergy
    {
        public FP MaxEnergy { get; set; }
        public FP Energy { get; set; }
        public FP EnergyLoadPerTick { get; set; }
    }
}
