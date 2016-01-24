using System;

namespace DP_STUDY.Mediator
{
    class Player
    {
        public string name
        {
            get;
            private set;
        }

        public Player(string name)
        {
            this.name = name;
        }

        public void Join(GameRoom room)
        {
            room.Join(this);
        }

        public void Notify(string message)
        {
            Console.WriteLine(name + " recieved : " + message);
        }
    }
}
