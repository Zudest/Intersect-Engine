using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Intersect.GameObjects;
using Newtonsoft.Json;

namespace Intersect.Server.Database
{

    public class Skill
    {

        public Skill()
        {
        }

        public Skill(Guid skillId, int level = 1, long experience = 0, int status = 1)
        {
            SkillId = skillId;
            Level = level;
            Experience = experience;
            Status = status;

            var descriptor = SkillBase.Get(SkillId);
            if (descriptor == null)
            {
                return;
            }
        }

        public Skill(Skill skill) : this(skill.SkillId, skill.Level, skill.Experience, skill.Status)
        {
        }

        public Guid SkillId { get; set; }

        [NotMapped]
        public string SkillName => SkillBase.GetName(SkillId);

        public int Level { get; set; }

        public long Experience { get; set; }

        public int Status { get; set; } //Used for enabled/disabled for now, maybe something else in the future

        public static Skill None => new Skill();

        [JsonIgnore]
        [NotMapped]
        public SkillBase Descriptor => SkillBase.Get(SkillId);

        public Skill Clone()
        {
            return new Skill(this);
        }

        public string Data()
        {
            return JsonConvert.SerializeObject(this);
        }

        public virtual void Set(Skill skill)
        {
            SkillId = skill.SkillId;
            Level = skill.Level;
            Experience = skill.Experience;
            Status = skill.Status;
        }

    }

}