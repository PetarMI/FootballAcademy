using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballAcademy.Players;
using FootballAcademy.Academy;

namespace FootballAcademy.Teams
{
    class Team
    {
        private String name;
        IList<IDefender> defenders = new List<IDefender>();
        IList<IMidfielder> midfielders = new List<IMidfielder>();
        IList<IStriker> strikers = new List<IStriker>();

        public Team(String name)
        {
            this.name = name;
        }

        public void AddDefender(IDefender def)
        {
            defenders.Add(def);
        }

        public void AddMidfielder(IMidfielder mid)
        {
            this.midfielders.Add(mid);
        }

        public void AddStriker(IStriker str)
        {
            this.strikers.Add(str);
        }

        public void PrintTeamInfo()
        {
            foreach (var player in defenders)
            {
                Console.WriteLine(player.ToString());
            }

            foreach (var player in midfielders)
            {
                Console.WriteLine(player.ToString());
            }

            foreach (var player in strikers)
            {
                Console.WriteLine(player.ToString());
            }

            Console.WriteLine();
        }

        public void PrintTeamFormation()
        {
            Console.WriteLine(String.Format("---{0}---{1}---", defenders[0].Name(), defenders[1].Name()));
            Console.WriteLine(String.Format("---{0}---{1}---", midfielders[0].Name(), midfielders[1].Name()));
            Console.WriteLine(String.Format("-----{0}----", strikers[0].Name()));
        }
    }
}
