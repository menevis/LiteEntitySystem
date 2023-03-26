﻿using LiteNetLib;

namespace LiteEntitySystem
{
    public class NetPlayer
    {
        public readonly byte Id;
        public readonly NetPeer Peer;
        
        internal ushort LastProcessedTick;
        internal ushort LastReceivedTick;
        internal ushort CurrentServerTick;
        internal ushort StateATick;
        internal ushort StateBTick;
        internal ushort SimulatedServerTick;
        internal float LerpTime;
        internal NetPlayerState State;
        internal int ArrayIndex;

        internal ushort AvailableInputCount;
        internal readonly InputBuffer[] AvailableInput = new InputBuffer[ServerEntityManager.MaxStoredInputs];

        internal NetPlayer(NetPeer peer, byte id)
        {
            Peer = peer;
            Id = id;
        }
    }
}