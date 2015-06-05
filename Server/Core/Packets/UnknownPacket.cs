﻿using ProtoBuf;
using xServer.Core.Networking;

namespace xServer.Core.Packets
{
    [ProtoContract]
    public class UnknownPacket : IPacket
    {
        [ProtoMember(1)]
        public IPacket Packet { get; set; }

        public UnknownPacket()
        {
        }

        public UnknownPacket(IPacket packet)
        {
            Packet = packet;
        }

        public void Execute(Client client)
        {
            client.Send(this);
        }
    }
}