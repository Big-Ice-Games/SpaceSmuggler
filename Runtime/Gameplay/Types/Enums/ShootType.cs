namespace SpaceSmuggler.Gameplay.Types.Enums
{
    /// <summary>
    /// This type define how we are representing single attack in the game.
    /// This representation is basic and can be modified with <see cref="Runtime.EntityWeapon"/> adding color and other details to it.
    /// </summary>
    public enum ShootType
    {
        None,
        Beam,
        Plasma,
        Disruptor,
        Rocket
    }
}
