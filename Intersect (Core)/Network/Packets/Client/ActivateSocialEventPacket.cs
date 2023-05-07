using MessagePack;
using System;

namespace Intersect.Network.Packets.Client
{
    [MessagePackObject]
    public partial class ActivateSocialEventPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public ActivateSocialEventPacket()
        {

        }

        public ActivateSocialEventPacket(Guid mapId, Guid eventId, int proximity)
        {
            MapId = mapId;
            EventId = eventId;
            Proximity = proximity;
        }

        [Key(0)]
        public Guid MapId { get; set; }

        [Key(1)]
        public Guid EventId { get; set; }

        [Key(2)]
        public int Proximity { get; set; }

    }

}
