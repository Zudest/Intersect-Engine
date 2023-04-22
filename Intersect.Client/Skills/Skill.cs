using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect.Client.Skills
{

    public class Skill
    {
        public Guid SkillId;

        public int Level;

        public long Experience;

        public int Status;

        public Skill Clone()
        {
            var newSkill = new Skill()
            {
                SkillId = SkillId,
                Level = Level,
                Experience = Experience,
                Status = Status
            };

            return newSkill;
        }

        public void Load(Guid skillId, int level, long experience, int status)
        {
            SkillId = skillId;
            Level = level;
            Experience = experience;
            Status = status;
        }

    }

}