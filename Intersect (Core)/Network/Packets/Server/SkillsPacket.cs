using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class SkillsPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public SkillsPacket()
        {
        }

        public SkillsPacket(SkillUpdatePacket[] slots)
        {
            Slots = slots;
        }

        [Key(0)]
        public SkillUpdatePacket[] Slots { get; set; }

    }

}