using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intersect.Collections;
using MessagePack;

namespace Intersect.Network.Packets.Client
{
    [MessagePackObject]
    public class ForgetSkillPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public ForgetSkillPacket()
        {
        }

        public ForgetSkillPacket(int slot)
        {
            Slot = slot;
        }

        [Key(0)]
        public int Slot { get; set; }

        public override Dictionary<string, SanitizedValue<object>> Sanitize()
        {
            var sanitizer = new Sanitizer();

            Slot = sanitizer.Maximum(nameof(Slot), Slot, 0);

            return sanitizer.Sanitized;
        }

    }

}
