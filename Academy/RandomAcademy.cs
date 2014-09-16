using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballAcademy.Players;

namespace FootballAcademy.Academy
{
    class RandomAcademy : IFootballAcademy
    { 
        private const String teamName = "World wide academy";
        private static readonly RandomAcademy instance = new RandomAcademy();

        private RandomAcademy() { }

        public static RandomAcademy AcademyRandom
        {
            get
            {
                return instance;
            }
        }

        public String AcademyName
        {
            get { return teamName; }
        }

        public Defender CreateDefender()
        {
            return new Defender(NameGenerator.GenerateName(), 13, 9, 9, this.AcademyName);
        }

        public Midfielder CreateMidfielder()
        {
            return new Midfielder(NameGenerator.GenerateName(), 4, 15, 18, this.AcademyName);
        }

        public Striker CreateStriker()
        {
            return new Striker(NameGenerator.GenerateName(), 5, 13, 19, this.AcademyName);
        }
    }
}
