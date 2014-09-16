using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballAcademy.Players
{
    class Striker : Player, IStriker
    {
        public Striker(String name, uint defending, uint passing, uint goalScoring, String club)
            : base(name, defending, passing, goalScoring, PlayerPosition.Striker, club)
        { }

        public void ScoreGoal()
        {
            Console.WriteLine("Striker scored goal");
        }
    }
}
