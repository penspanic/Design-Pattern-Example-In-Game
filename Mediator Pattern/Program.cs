using System;
using DP_STUDY.Mediator;

namespace DP_STUDY
{
    class Program
    {

        static void Main(string[] args)
        {

            RankGameRoom room101 = new RankGameRoom();

            Player player01 = new Player("penspanic");
            Player player02 = new Player("Geun Hee");

            player01.Join(room101);
            player02.Join(room101);

            room101.GameStart();

        }
    }
}
