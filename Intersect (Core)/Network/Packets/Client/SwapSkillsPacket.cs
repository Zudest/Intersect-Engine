using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;

namespace Intersect.Network.Packets.Client
{
    [MessagePackObject]
    public class SwapSkillsPacket : SlotSwapPacket
    {
        //Parameterless Constructor for MessagePack
        public SwapSkillsPacket() : base(0, 0)
        {
        }

        public SwapSkillsPacket(int slot1, int slot2) : base(slot1, slot2) { }

    }

}