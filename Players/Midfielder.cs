using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballAcademy.Players
{
    class Midfielder : Player, IMidfielder
    {
        public Midfielder(String name, uint defending, uint passing, uint goalScoring, String club)
            : base(name, defending, passing, goalScoring, PlayerPosition.Midfielder, club)
        { }

        public void PassBall()
        {
            Console.WriteLine("Midfielder passed the ball");
        }
    }
}
