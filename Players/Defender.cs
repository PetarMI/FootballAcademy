using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballAcademy.Players
{
    class Defender : Player, IDefender
    {
        public Defender(String name, uint defending, uint passing, uint goalScoring, String club)
            : base(name, defending, passing, goalScoring, PlayerPosition.Defender, club)
        { }

        public void TakeBall()
        {
            Console.WriteLine("Defender took ball away");
        }
    }
}
