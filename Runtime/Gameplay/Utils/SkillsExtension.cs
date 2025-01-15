using System.Collections.Generic;
using SpaceSmuggler.Gameplay.Types;
using SpaceSmuggler.Gameplay.Types.Enums;

namespace SpaceSmuggler.Gameplay.Utils
{
    public static class SkillsExtension
    {
        public static void Apply(this Skills skills, List<Property> properties)
        {
            foreach (Property property in properties)
            {
                if(property.Type == PropertyType.SkillBonus)
                    skills.Increase(property.SkillType, property.Value);
            }
        }

        public static void Increase(this Skills skills, SkillType skillType, int value)
        {
            switch (skillType)
            {
                case SkillType.Backstab: skills.Backstab += value; break;
                case SkillType.Beam: skills.Beam += value; break;
                case SkillType.Disrupt: skills.Disrupt += value; break;
                case SkillType.Dodge: skills.Dodge += value; break;
                case SkillType.Engineering: skills.Engineering += value; break;
                case SkillType.Focus: skills.Focus += value; break;
                case SkillType.Hacking: skills.Hacking += value; break;
                case SkillType.Hide: skills.Hide += value; break;
                case SkillType.Mining: skills.Mining += value; break;
                case SkillType.Navigation: skills.Navigation += value; break;
                case SkillType.Plasma: skills.Plasma += value; break;
                case SkillType.IceKinesis: skills.IceKinesis += value; break;
                case SkillType.Repair: skills.Repair += value; break;
                case SkillType.Rockets: skills.Rockets += value; break;
                case SkillType.Resistance: skills.Resistance += value; break;
                case SkillType.Shields: skills.Shields += value; break;
                case SkillType.Tactics: skills.Tactics += value; break;
            }
        }
    }
}
