﻿using LeaguePackets.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LeaguePackets.GamePackets
{
    public class S2C_ChangeSpell_OwnerOnly : GamePacket, IUnusedPacket // 0x125
    {
        //FIXME: 4.18+
        public override GamePacketID ID => GamePacketID.S2C_ChangeSpell_OwnerOnly;
        public static S2C_ChangeSpell_OwnerOnly CreateBody(PacketReader reader, NetID senderNetID)
        {
            var result = new S2C_ChangeSpell_OwnerOnly();
            result.SenderNetID = senderNetID;
        
            return result;
        }
        public override void WriteBody(PacketWriter writer)
        {
        }
    }
}