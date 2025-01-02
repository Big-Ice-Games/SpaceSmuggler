namespace SpaceSmuggler.Gameplay.Types.Enums
{
    public enum SkillType
    {
        None,

        /// <summary>
        /// Provides passive ability that is available if ship is behind his opponent and is hidden.
        /// Increase critical hit chance and critical hit damage on all the weapons for the first attack.
        /// </summary>
        Backstab,

        /// <summary>
        /// Increase hit chance for beams.
        /// Beams damage is 20% higher against shields.
        /// </summary>
        Beam,

        /// <summary>
        /// Increase hit chance for disruptors.
        /// Increase chance for applying disruption effect on hit.
        /// Disruption effect block random component on the ship for short period of time.
        /// </summary>
        Disrupt,

        /// <summary>
        /// Increase dodge chance.
        /// </summary>
        Dodge,

        /// <summary>
        /// Increase chance to create a better components from blueprints.
        /// Provides active abilities.
        /// Decrease repair time.
        /// </summary>
        Engineering,

        /// <summary>
        /// Increase psi regeneration ratio.
        /// Increase hit chance for beams and plasma.
        /// </summary>
        Focus,

        /// <summary>
        /// Provides active skills for debuffs.
        /// Increase resistance against hacking used on our player.
        /// Cost energy.
        /// </summary>
        Hacking,

        /// <summary>
        /// Provides active hide ability.
        /// Increase undetection by scanners.
        /// Increase time of being hidden.
        /// Cost energy.
        /// </summary>
        Hide,

        /// <summary>
        /// Provides mining ability.
        /// Increase success rate of mining.
        /// Increase possible level of ores that player can mine.
        /// Increase amount of ores that we are mining at once.
        /// Cost energy.
        /// </summary>
        Mining,

        /// <summary>
        /// Increase acceleration.
        /// Increase max speed.
        /// Increase rotation speed.
        /// Increase dodge chance.
        /// Decrease critical hit chance against this player.
        /// </summary>
        Navigation,

        /// <summary>
        /// Increase hit chance using plasmas.
        /// Plasma damage is 20% higher against hull points.
        /// </summary>
        Plasma,

        /// <summary>
        /// Provides active abilities.
        /// Cost psi points.
        /// </summary>
        IceKinesis,

        /// <summary>
        /// Provides active ability that let player repair hull points.
        /// Increase amount of hull points that can be repair at once.
        /// Cost energy.
        /// </summary>
        Repair,

        /// <summary>
        /// Increase hit chance using rockets.
        /// 1.0x vs shields and hull points.
        /// Consume rockets.
        /// </summary>
        Rockets,

        /// <summary>
        /// Decrease damage received against shield.
        /// Decrease hacking effects on us.
        /// Decrease disruption effect chance on us.
        /// Decrease damage taken from spells and special attacks. 
        /// </summary>
        Resistance,

        /// <summary>
        /// Increase shield regeneration ratio.
        /// Decrease peace time required for starting shield regeneration.
        /// </summary>
        Shields,

        /// <summary>
        /// Increase hit chance.
        /// Increase dodge chance.
        /// Increase critical hit chance.
        /// Increase damage.
        /// Increase armor.
        /// </summary>
        Tactics
    }
}
