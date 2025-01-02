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
        public float Backstab { get; set; }

        /// <summary>
        /// <see cref="SkillType.Beam"/>
        /// </summary>
        public float Beam { get; set; }

        /// <summary>
        /// <see cref="SkillType.Disrupt"/>
        /// </summary>
        public float Disrupt { get; set; }

        /// <summary>
        /// <see cref="SkillType.Dodge"/>
        /// </summary>
        public float Dodge { get; set; }

        /// <summary>
        /// <see cref="SkillType.Engineering"/>
        /// </summary>
        public float Engineering { get; set; }

        /// <summary>
        /// <see cref="SkillType.Focus"/>
        /// </summary>
        public float Focus { get; set; }

        /// <summary>
        /// <see cref="SkillType.Hacking"/>
        /// </summary>
        public float Hacking { get; set; }

        /// <summary>
        /// <see cref="SkillType.Hide"/>
        /// </summary>
        public float Hide { get; set; }

        /// <summary>
        /// <see cref="SkillType.Mining"/>
        /// </summary>
        public float Mining { get; set; }

        /// <summary>
        /// <see cref="SkillType.Navigation"/>
        /// </summary>
        public float Navigation { get; set; }

        /// <summary>
        /// <see cref="SkillType.Plasma"/>
        /// </summary>
        public float Plasma { get; set; }

        /// <summary>
        /// <see cref="SkillType.IceKinesis"/>
        /// </summary>
        public float IceKinesis { get; set; }

        /// <summary>
        /// <see cref="SkillType.Repair"/>
        /// </summary>
        public float Repair { get; set; }

        /// <summary>
        /// <see cref="SkillType.Rockets"/>
        /// </summary>
        public float Rockets { get; set; }

        /// <summary>
        /// <see cref="SkillType.Resistance"/>
        /// </summary>
        public float Resistance { get; set; }

        /// <summary>
        /// <see cref="SkillType.Shields"/>
        /// </summary>
        public float Shields { get; set; }

        /// <summary>
        /// <see cref="SkillType.Tactics"/>
        /// </summary>
        public float Tactics { get; set; }
    }
}