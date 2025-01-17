using System.Collections.Generic;

namespace SpaceSmuggler.Gameplay.Types
{
    public static class Blueprints
    {
        private static Dictionary<string, IBlueprint> _blueprints;

        public static void InitBlueprints(List<IBlueprint> blueprints)
        {
            _blueprints = new Dictionary<string, IBlueprint>(blueprints.Count);
            foreach (IBlueprint blueprint in blueprints)
            {
                _blueprints.Add(blueprint.Name, blueprint);
            }
        }

        public static IBlueprint GetBlueprint(this ShipComponent shipComponent)
        {
            return _blueprints.GetValueOrDefault(shipComponent.BlueprintName);
        }
    }
}
