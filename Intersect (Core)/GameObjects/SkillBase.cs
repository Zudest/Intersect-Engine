using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

using Intersect.Models;
using Intersect.GameObjects.Events;
using Intersect.Server.Utilities;

using Newtonsoft.Json;

namespace Intersect.GameObjects
{
    public class SkillBase : DatabaseObject<SkillBase>, IFolderable
    {
        public const long DEFAULT_BASE_EXPERIENCE = 100;

        public const long DEFAULT_EXPERIENCE_INCREASE = 50;

        [JsonConstructor]
        public SkillBase(Guid id) : base(id)
        {
            Name = "New Skill";

            ExperienceCurve = new ExperienceCurve();
            ExperienceCurve.Calculate(1);
            BaseExp = DEFAULT_BASE_EXPERIENCE;
            ExpIncrease = DEFAULT_EXPERIENCE_INCREASE;
        }

        //Parameterless constructor for EF
        public SkillBase()
        {
            Name = "New Skill";

            ExperienceCurve = new ExperienceCurve();
            ExperienceCurve.Calculate(1);
            BaseExp = DEFAULT_BASE_EXPERIENCE;
            ExpIncrease = DEFAULT_EXPERIENCE_INCREASE;
        }

        //General Properties: 

        public string Icon { get; set; } = "";

        [JsonProperty]
        public int MaxLevel { get; set; }

        [JsonProperty]
        public int Order { get; set; }

        /// <inheritdoc />
        public string Folder { get; set; } = "";

        public string Description { get; set; } = "";

        //Animations: 

        [Column("LevelUpAnimation")]
        [JsonProperty]
        public Guid LevelUpAnimationId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public AnimationBase LevelUpAnimation
        {
            get => AnimationBase.Get(LevelUpAnimationId);
            set => LevelUpAnimationId = value?.Id ?? Guid.Empty;
        }

        [Column("LevelMaxAnimation")]
        [JsonProperty]
        public Guid LevelMaxAnimationId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public AnimationBase LevelMaxAnimation
        {
            get => AnimationBase.Get(LevelMaxAnimationId);
            set => LevelMaxAnimationId = value?.Id ?? Guid.Empty;
        }

        [Column("Class")]
        [JsonProperty]
        public Guid ClassId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public ClassBase Class
        {
            get => ClassBase.Get(ClassId);
            set => ClassId = value?.Id ?? Guid.Empty;
        }

        //Experience:

        [JsonIgnore] private long mBaseExp;

        [JsonIgnore] private long mExpIncrease;

        [NotMapped] public Dictionary<int, long> ExperienceOverrides = new Dictionary<int, long>();

        public long BaseExp
        {
            get => mBaseExp;
            set
            {
                mBaseExp = Math.Max(0, value);
                ExperienceCurve.BaseExperience = Math.Max(1, mBaseExp);
            }
        }

        public long ExpIncrease
        {
            get => mExpIncrease;
            set
            {
                mExpIncrease = Math.Max(0, value);
                ExperienceCurve.Gain = 1 + value / 100.0;
            }
        }

        [JsonIgnore]
        [NotMapped]
        public ExperienceCurve ExperienceCurve { get; }

        [JsonIgnore]
        [Column("ExperienceOverrides")]
        public string ExpOverridesJson
        {
            get => JsonConvert.SerializeObject(ExperienceOverrides);
            set
            {
                ExperienceOverrides = JsonConvert.DeserializeObject<Dictionary<int, long>>(value ?? "");
                if (ExperienceOverrides == null)
                {
                    ExperienceOverrides = new Dictionary<int, long>();
                }
            }
        }

        // Methods:

        public long ExperienceToNextLevel(int level)
        {
            if (ExperienceOverrides.ContainsKey(level))
            {
                return ExperienceOverrides[level];
            }

            return ExperienceCurve.Calculate(level);
        }
    }

}