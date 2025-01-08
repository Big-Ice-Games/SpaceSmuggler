namespace SpaceSmuggler.Runtime
{
    public sealed class EntityEnergy
    {
        public float MaxEnergy { get; set; }
        public float Energy { get; set; }
        public float EnergyLoadPerTick { get; set; }

        public void Tick()
        {
            Energy += EnergyLoadPerTick;
            if (Energy > MaxEnergy) 
                Energy = MaxEnergy;
        }
    }
}
