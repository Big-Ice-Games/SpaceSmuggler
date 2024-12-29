namespace SpaceSmuggler
{
    /// <summary>
    /// Main hub that holds logic responsible for crafting.
    /// </summary>
    public sealed class Forge
    {
        private readonly ForgeSettings _settings;
        private readonly ArmorForge _armorForge;
        private readonly BeamForge _beamForge;
        private readonly DisruptionForge _disruptionForge;
        private readonly EnergyCoreForge _energyCoreForge;
        private readonly EngineForge _engineForge;
        private readonly PlasmaForge _plasmaForge;
        private readonly PropertiesForge _propertiesForge;
        private readonly RocketLauncherForge _rocketLauncherForge;
        private readonly ScannerForge _scannerForge;
        private readonly ShieldForge _shieldForge;


        internal Forge(
            ForgeSettings settings,
            ArmorForge armorForge,
            BeamForge beamForge,
            DisruptionForge disruptionForge,
            EnergyCoreForge energyCoreForge,
            EngineForge engineForge,
            PlasmaForge plasmaForge,
            PropertiesForge propertiesForge,
            RocketLauncherForge rocketLauncherForge,
            ScannerForge scannerForge,
            ShieldForge shieldForge)
        {
            _settings = settings;
            _armorForge = armorForge;
            _beamForge = beamForge;
            _disruptionForge = disruptionForge;
            _energyCoreForge = energyCoreForge;
            _engineForge = engineForge;
            _plasmaForge = plasmaForge;
            _propertiesForge = propertiesForge;
            _rocketLauncherForge = rocketLauncherForge;
            _scannerForge = scannerForge;
            _shieldForge = shieldForge;
        }
    }
}
