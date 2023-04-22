using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

using Intersect.Server.Entities;

using Newtonsoft.Json;

// ReSharper disable UnusedAutoPropertyAccessor.Local
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Local

namespace Intersect.Server.Database.PlayerData.Players
{

    public class SkillSlot : Skill, ISlot, IPlayerOwned
    {

        public SkillSlot()
        {
        }

        public SkillSlot(int slot)
        {
            Slot = slot;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), JsonIgnore]
        public Guid Id { get; private set; }

        [JsonIgnore]
        public Guid PlayerId { get; private set; }

        [JsonIgnore]
        public virtual Player Player { get; private set; }

        public int Slot { get; private set; }

    }

}