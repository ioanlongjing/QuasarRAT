﻿using ProtoBuf;

namespace Core.Packets.ServerPackets
{
    [ProtoContract]
    public class GetProcesses : IPacket
    {
        public GetProcesses() { }

        public void Execute(Client client)
        {
            client.Send<GetProcesses>(this);
        }
    }
}
