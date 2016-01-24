using System;
using System.Collections.Generic;

namespace DP_STUDY.Mediator
{
    // Abstract class for all kind of game rooms.
    abstract class GameRoom
    {
        private List<Player> playerList = new List<Player>();
        private readonly int capacity;
        protected string joinMessage;

        protected GameRoom(int capacity)
        {
            this.capacity = capacity;
            playerList.Capacity = this.capacity;
        }

        public void Join(Player player)
        {
            if (playerList.Count == capacity)
            {
                player.Notify("This room is full!");
                return;
            }

            playerList.Add(player);
            player.Notify(joinMessage);

            foreach (Player eachPlayer in playerList)
            {
                if (eachPlayer == player)
                    continue;

                eachPlayer.Notify(player.name + " Joined!");
            }
        }

        void NotifyAllPlayers(string message)
        {
            foreach (Player eachPlayer in playerList)
                eachPlayer.Notify(message);
        }

        public void GameStart()
        {
            const int waitTime = 5;

            for (int i = 0; i < waitTime; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Beep();
                NotifyAllPlayers((waitTime - i).ToString());
            }
            NotifyAllPlayers("Game Start!");
        }
    }
}
