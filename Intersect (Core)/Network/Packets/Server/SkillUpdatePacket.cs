using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;
using System;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class SkillUpdatePacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public SkillUpdatePacket()
        {
        }

        public SkillUpdatePacket(int slot, Guid skillId, int level, long experience, int status)
        {
            Slot = slot;
            SkillId = skillId;
            Level = level;
            Experience = experience;
            Status = status;
        }

        [Key(0)]
        public int Slot { get; set; }

        [Key(1)]
        public Guid SkillId { get; set; }

        [Key(2)]
        public int Level { get; set; }

        [Key(3)]
        public long Experience { get; set; }

        [Key(4)]
        public int Status { get; set; }
    }

}
