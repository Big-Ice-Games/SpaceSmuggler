using System.Collections.Generic;
using BIG;

namespace SpaceSmuggler.Gameplay.Types
{
    [RegistrationRequired]
    public sealed class Blueprints
    {
        private readonly Dictionary<string, IBlueprint> _blueprints;

        public Blueprints(List<IBlueprint> blueprints)
        {
            _blueprints = new Dictionary<string, IBlueprint>(blueprints.Count);
            foreach (IBlueprint blueprint in blueprints)
            {
                _blueprints.Add(blueprint.Name, blueprint);
            }
        }

        public IBlueprint? GetBlueprint(ShipComponent? shipComponent)
        {
            if (shipComponent == null) return null;
            return _blueprints.GetValueOrDefault(shipComponent.BlueprintName);
        }
    }
}
