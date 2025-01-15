using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Types
{
    /// <summary>
    /// Hold all the skills values for an entity.
    /// Skills are a part of a player account and its progression.
    /// For AI entities skills are generated based on the entity level etc.
    /// </summary>
    public sealed class Skills
    {
        /// <summary>
        /// <see cref="SkillType.Backstab"/>
        /// </summary>
        public int Backstab { get; set; }

        /// <summary>
        /// <see cref="SkillType.Beam"/>
        /// </summary>
        public int Beam { get; set; }

        /// <summary>
        /// <see cref="SkillType.Disrupt"/>
        /// </summary>
        public int Disrupt { get; set; }

        /// <summary>
        /// <see cref="SkillType.Dodge"/>
        /// </summary>
        public int Dodge { get; set; }

        /// <summary>
        /// <see cref="SkillType.Engineering"/>
        /// </summary>
        public int Engineering { get; set; }

        /// <summary>
        /// <see cref="SkillType.Focus"/>
        /// </summary>
        public int Focus { get; set; }

        /// <summary>
        /// <see cref="SkillType.Hacking"/>
        /// </summary>
        public int Hacking { get; set; }

        /// <summary>
        /// <see cref="SkillType.Hide"/>
        /// </summary>
        public int Hide { get; set; }

        /// <summary>
        /// <see cref="SkillType.Mining"/>
        /// </summary>
        public int Mining { get; set; }

        /// <summary>
        /// <see cref="SkillType.Navigation"/>
        /// </summary>
        public int Navigation { get; set; }

        /// <summary>
        /// <see cref="SkillType.Plasma"/>
        /// </summary>
        public int Plasma { get; set; }

        /// <summary>
        /// <see cref="SkillType.IceKinesis"/>
        /// </summary>
        public int IceKinesis { get; set; }

        /// <summary>
        /// <see cref="SkillType.Repair"/>
        /// </summary>
        public int Repair { get; set; }

        /// <summary>
        /// <see cref="SkillType.Rockets"/>
        /// </summary>
        public int Rockets { get; set; }

        /// <summary>
        /// <see cref="SkillType.Resistance"/>
        /// </summary>
        public int Resistance { get; set; }

        /// <summary>
        /// <see cref="SkillType.Shields"/>
        /// </summary>
        public int Shields { get; set; }

        /// <summary>
        /// <see cref="SkillType.Tactics"/>
        /// </summary>
        public int Tactics { get; set; }
    }
}