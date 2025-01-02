using Autofac;
using BIG;
using SpaceSmuggler.Gameplay.Forge;

namespace SpaceSmuggler
{
    public sealed class SpaceSmugglerAssemblyModule : AssemblyModule
    {
        public override void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder.Register(c => new MainThreadActionQueue())
                .As<MainThreadActionQueue>()
                .Keyed<object>(typeof(MainThreadActionQueue).FullName)
                .SingleInstance();

            RegisterForge(containerBuilder);
        }

        private void RegisterForge(ContainerBuilder containerBuilder)
        {
            containerBuilder.Register(c => new ArmorForge()).As<ArmorForge>().SingleInstance();
            containerBuilder.Register(c => new BeamForge()).As<BeamForge>().SingleInstance();
            containerBuilder.Register(c => new DisruptionForge()).As<DisruptionForge>().SingleInstance();
            containerBuilder.Register(c => new EnergyCoreForge()).As<EnergyCoreForge>().SingleInstance();
            containerBuilder.Register(c => new EngineForge()).As<EngineForge>().SingleInstance();
            containerBuilder.Register(c => new PlasmaForge()).As<PlasmaForge>().SingleInstance();
            containerBuilder.Register(c => new PropertiesForge()).As<PropertiesForge>().SingleInstance();
            containerBuilder.Register(c => new RocketLauncherForge()).As<RocketLauncherForge>().SingleInstance();
            containerBuilder.Register(c => new ScannerForge()).As<ScannerForge>().SingleInstance();
            containerBuilder.Register(c => new ShieldForge()).As<ShieldForge>().SingleInstance();
            containerBuilder.Register(c => new Forge(
                    c.Resolve<ForgeSettings>(),
                    c.Resolve<ArmorForge>(),
                    c.Resolve<BeamForge>(),
                    c.Resolve<DisruptionForge>(),
                    c.Resolve<EnergyCoreForge>(),
                    c.Resolve<EngineForge>(),
                    c.Resolve<PlasmaForge>(),
                    c.Resolve<PropertiesForge>(),
                    c.Resolve<RocketLauncherForge>(),
                    c.Resolve<ScannerForge>(),
                    c.Resolve<ShieldForge>()))
                .As<Forge>()
                .Keyed<object>(typeof(Forge).FullName)
                .SingleInstance();
        }
    }
}
