using System;

namespace DP_STUDY.Mediator
{
    class RankGameRoom : GameRoom
    {
        const int RankGameRoomCapacity = 4;
        public RankGameRoom() : base(RankGameRoomCapacity)
        {
            joinMessage = "Welcome to rank mode!";
        }  
    }
}
