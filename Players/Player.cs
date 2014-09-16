using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballAcademy.Players
{
    abstract class Player
    {
        private String name;
        private Skills skills;
        private PlayerPosition position;
        private String domesticClub;

        public Player(String name, uint defending, uint passing, uint goalScoring, PlayerPosition pos, String club)
        {
            this.name = name;
            this.skills = new Skills(defending, passing, goalScoring);
            this.position = pos;
            this.domesticClub = club;
        }

        public String Name()
        {
            return this.name;
        }

        public void ImproveSkill(uint defending, uint passing, uint goalScoring)
        {
            this.skills.Defending += defending;
            this.skills.Passing += passing;
            this.skills.GoalScoring += goalScoring;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\nPosition: {1}\nDefending: {2}\nPassing: {3}\nGoal Scoring: {4}\n\n", name, position, skills.Defending, skills.Passing, skills.GoalScoring);
        }
    }
}
