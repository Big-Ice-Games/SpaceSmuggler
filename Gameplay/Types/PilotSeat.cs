namespace SpaceSmuggler
{
    /// <summary>
    /// Like a <see cref="ShipComponentSlot"/> this is seat on the ship that can be used to
    /// attach <see cref="Pilot"/> card to it. 
    /// </summary>
    public sealed class PilotSeat
    {
        public Pilot Pilot { get; set; }
    }
}
