using System.Collections.Generic;

namespace SpaceSmuggler.Runtime
{
    /// <summary>
    /// This class represents players and other entities in the match.
    /// Work in progress..
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// Description is used to display entity name and UI type on the game client side.
        /// </summary>
        public EntityDescription Description { get; set; }

        /// <summary>
        /// Shield.
        /// </summary>
        public EntityShield Shield { get; set; }

        /// <summary>
        /// List of weapons.
        /// </summary>
        public List<EntityWeapon> Weapons { get; set; }

        /// <summary>
        /// Psi (mana).
        /// </summary>
        public EntityPsi Psi { get; set; }

        /// <summary>
        /// Energy.
        /// </summary>
        public EntityEnergy Energy { get; set; }

        /// <summary>
        /// Maximum hull points
        /// </summary>
        public float HullPoints { get; set; }

        /// <summary>
        /// Current hull points.
        /// </summary>
        public float CurrentHullPoints { get; set; }

        /// <summary>
        /// Physics values for entity.
        /// </summary>
        public EntityPhysics Physics { get; set; }

        /// <summary>
        /// Add all components energy costs for next tick.
        /// </summary>
        /// <returns>Amount of energy we need to tick all components.</returns>
        private float EnergyRequiredForTick()
        {
            var energy = Shield.GetEnergyCost();
            for (int i = 0; i < Weapons.Count; i++)
            {
                energy += Weapons[i].GetEnergyCost();
            }

            return energy;
        }

        /// <summary>
        /// Tick shield and weapons.
        /// </summary>
        /// <param name="tickPercentage">1 = 100% tick or less if we have no enough energy to perform full tick.</param>
        private void TickComponents(float tickPercentage)
        {
            Shield.Tick(tickPercentage);
            for (int i = 0; i < Weapons.Count; i++)
            {
                 Weapons[i].Tick(tickPercentage);
            }
        }

        /// <summary>
        /// Tick the whole entity.
        /// </summary>
        public void Tick()
        {
            Energy.Tick();
            var requiredEnergy = EnergyRequiredForTick();
            // If we don't have enough energy.
            if (requiredEnergy > Energy.Energy)
            {
                // Calculate % of energy we have vs what we need.
                var percentage = Energy.Energy / requiredEnergy;

                // We tick components with multiplier less than 1.
                TickComponents(percentage);

                // We consumed whole energy for such tick.
                Energy.Energy = 0;
            }
            else
            {
                // We have enough energy so we tick components fully and consume full amount of energy from energy source.
                TickComponents(1f);
                Energy.Energy -= requiredEnergy;
            }
        }
    }
}
