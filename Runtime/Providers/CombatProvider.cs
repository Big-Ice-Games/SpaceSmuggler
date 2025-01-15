using System;
using System.Collections.Generic;
using System.Text;
using Photon.Deterministic;
using SpaceSmuggler.Gameplay.Runtime;

namespace SpaceSmuggler.Runtime.Providers
{
    public static class CombatProvider
    {
        public FP HitChance(Entity entity, int weaponIndex)
        {
            return entity.Weapons[weaponIndex].HitChance;
        }
    }
}
